using System;
using System.Runtime.InteropServices;
using EasyHook;
using TinkerWorX.Blizzard.Types;
using TinkerWorX.SharpCraft.Plugins;

/*
xref ".\CGxDeviceD3d\CGxDeviceD3d.cpp"
this function is the constructor for CGxDeviceD3d.
xref the function.
this function is the initializer that either starts opengl or directx.
**
      v8 = sub_6F52A0C0();
      dword_6FACBD40 = (int)v8; <- this is the dword we're looking for.
**
**
  dword_6FA88724 = a1; <- this is the dword that tells us if we're using opengl or directx.
  dword_6FA88720 = a3;
**

dword_6FA88724 = IsDirectX (true=directx, false=opengl)
dword_6FACBD40 = CGxDeviceD3d
 + 1396(349x4)/0x574 is the window handle.
 ...
 + 1404(351x4)/0x57C is the d3d8.dll module handle. (maybe)
 + 1408(352x4)/0x580 is a IDirect3D8
 + 1412(353x4)/0x584 is a IDirect3DDevice8
 + 1416(354x4)/0x588 is a D3DCAPS8
 ...
 + 1748(437x4)/0x6D4 is a D3DDISPLAYMODE (maybe)
 ...
 + 1764(441x4)/0x6E4 is a CheckDeviceFormat HRESULT
*/

namespace TinkerWorX.SharpCraft.plugins
{
    unsafe public class RenderingPlugin : FullPluginBase
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr LoadLibrary(String moduleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetModuleHandle(String moduleName);

        public override String Name { get { return "The Direct X Plugin"; } }

        public override Version Version { get { return new Version(0, 0, 0, 0); } }

        private IDirect3DDevice8* FindDevice(IntPtr address, UInt32 length)
        {
            // http://www.unknowncheats.me/forum/c-and-c/68893-d3d8-simple-hooking-any-games-directx8.html
            UInt32 count = 0;
            UInt32 start = (UInt32)address;
            for (var i = 0; i < length; i++)
            {
                if (*(byte*)(start + i + 0x00) == 0xC7) count++;
                if (*(byte*)(start + i + 0x01) == 0x06) count++;
                if (*(byte*)(start + i + 0x06) == 0x89) count++;
                if (*(byte*)(start + i + 0x07) == 0x86) count++;
                if (*(byte*)(start + i + 0x0C) == 0x89) count++;
                if (*(byte*)(start + i + 0x0D) == 0x86) count++;
                if (count == 6)
                    return (IDirect3DDevice8*)(start + i + 2);
                count = 0;
            }
            return null;
        }

        private LocalHook EndSceneLocalHook;

        public override void Initialize()
        {
            //Console.WriteLine();

            // first we locate the device.
            var module = GetModuleHandle("d3d8.dll");
            if (module == IntPtr.Zero)
                module = LoadLibrary("d3d8.dll");
            //Console.WriteLine(" - - d3d8: {0}", "0x" + module.ToString("X8"));

            var device = FindDevice(module, 0x128000);
            //Console.WriteLine(" - - device: {0}", "0x" + new IntPtr(device).ToString("X8"));

            // then we hook endscene, so we can postprocess it.
            this.EndSceneLocalHook = LocalHook.Create(device->VTable->EndScenePtr, new IDirect3DDevice8VTable.EndScenePrototype(this.EndSceneHook), null);
            this.EndSceneLocalHook.ThreadACL.SetInclusiveACL(new[] { 0 });

            //Console.Write(" - - ");
        }

        private Int32 EndSceneHook(IDirect3DDevice8* device)
        {
            var result = device->EndScene();

            var rects = new D3DRECT[] { 
                new D3DRECT{ X1 = 110, Y1 = 110, X2 = 210, Y2 = 210 },
                new D3DRECT{ X1 = 310, Y1 = 310, X2 = 400, Y2 = 400 }
            };

            device->Clear(rects, D3DClear.Target, Color.Yellow, 0.00f, 0);

            return result;
        }
    }

    unsafe public struct IDirect3D8
    {
        public IDirect3D8VTable* VTable;
    }

    unsafe public struct IDirect3D8VTable
    {
        // The vtable offsets was found here: https://github.com/ecere/ecere-sdk/blob/master/deps/DirectX-9.0/include/d3d8.h

        public IntPtr QueryInterfacePtr;
        public IntPtr AddRef;
        public IntPtr Release;
        public IntPtr RegisterSoftwareDevice;
        public IntPtr GetAdapterCount;
        public IntPtr GetAdapterIdentifier;
        public IntPtr GetAdapterModeCount;
        public IntPtr EnumAdapterModes;
        public IntPtr GetAdapterDisplayMode;
        public IntPtr CheckDeviceType;
        public IntPtr CheckDeviceFormat;
        public IntPtr CheckDeviceMultiSampleType;
        public IntPtr CheckDepthStencilMatch;
        public IntPtr GetDeviceCaps;
        public IntPtr GetAdapterMonitor;
        public IntPtr CreateDevicePtr;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        unsafe public delegate Int32 CreateDevicePrototype(
            IDirect3D8* direct3d, UInt32 adapter, D3DDeviceType deviceType, IntPtr hwnd, D3DCreate flags, ref D3DPRESENT_PARAMETERS presentationParameters, IDirect3DDevice8** device);
        public CreateDevicePrototype CreateDevice
        {
            get { return (CreateDevicePrototype)Marshal.GetDelegateForFunctionPointer(this.CreateDevicePtr, typeof(CreateDevicePrototype)); }
        }
    }

    unsafe public struct IDirect3DDevice8
    {
        public IDirect3DDevice8VTable* VTable;

        public Int32 EndScene()
        {
            fixed (IDirect3DDevice8* @this = &this)
                return @this->VTable->EndScene(@this);
        }

        public Int32 Clear(Int32 count, D3DRECT* rects, D3DClear flags, Color color, Single z, Int32 stencil)
        {
            fixed (IDirect3DDevice8* @this = &this)
                return @this->VTable->Clear(@this, count, rects, flags, color, z, stencil);
        }

        public Int32 Clear(D3DRECT[] rects, D3DClear flags, Color color, Single z, Int32 stencil)
        {
            fixed (IDirect3DDevice8* @this = &this)
            fixed (D3DRECT* pRects = rects)
            {
                return @this->Clear(rects.Length, pRects, flags, color, z, stencil);
            }
        }
    }

    unsafe public struct IDirect3DDevice8VTable
    {
        // The vtable offsets was found here: https://github.com/ecere/ecere-sdk/blob/master/deps/DirectX-9.0/include/d3d8.h
        public IntPtr QueryInterfacePtr;
        public IntPtr AddRefPtr;
        public IntPtr ReleasePtr;
        public IntPtr TestCooperativeLevelPtr;
        public IntPtr GetAvailableTextureMemPtr;
        public IntPtr ResourceManagerDiscardBytesPtr;
        public IntPtr GetDirect3DPtr;
        public IntPtr GetDeviceCapsPtr;
        public IntPtr GetDisplayModePtr;
        public IntPtr GetCreationParametersPtr;
        public IntPtr SetCursorPropertiesPtr;
        public IntPtr SetCursorPositionPtr;
        public IntPtr ShowCursorPtr;
        public IntPtr CreateAdditionalSwapChainPtr;
        public IntPtr ResetPtr;
        public IntPtr PresentPtr;
        public IntPtr GetBackBufferPtr;
        public IntPtr GetRasterStatusPtr;
        public IntPtr SetGammaRampPtr;
        public IntPtr GetGammaRampPtr;
        public IntPtr CreateTexturePtr;
        public IntPtr CreateVolumeTexturePtr;
        public IntPtr CreateCubeTexturePtr;
        public IntPtr CreateVertexBufferPtr;
        public IntPtr CreateIndexBufferPtr;
        public IntPtr CreateRenderTargetPtr;
        public IntPtr CreateDepthStencilSurfacePtr;
        public IntPtr CreateImageSurfacePtr;
        public IntPtr CopyRectsPtr;
        public IntPtr UpdateTexturePtr;
        public IntPtr GetFrontBufferPtr;
        public IntPtr SetRenderTargetPtr;
        public IntPtr GetRenderTargetPtr;
        public IntPtr GetDepthStencilSurfacePtr;
        public IntPtr BeginScenePtr;
        public IntPtr EndScenePtr;
        public IntPtr ClearPtr;
        public IntPtr SetTransformPtr;
        public IntPtr GetTransformPtr;
        public IntPtr MultiplyTransformPtr;
        public IntPtr SetViewportPtr;
        public IntPtr GetViewportPtr;
        public IntPtr SetMaterialPtr;
        public IntPtr GetMaterialPtr;
        public IntPtr SetLightPtr;
        public IntPtr GetLightPtr;
        public IntPtr LightEnablePtr;
        public IntPtr GetLightEnablePtr;
        public IntPtr SetClipPlanePtr;
        public IntPtr GetClipPlanePtr;
        public IntPtr SetRenderStatePtr;
        public IntPtr GetRenderStatePtr;
        public IntPtr BeginStateBlockPtr;
        public IntPtr EndStateBlockPtr;
        public IntPtr ApplyStateBlockPtr;
        public IntPtr CaptureStateBlockPtr;
        public IntPtr DeleteStateBlockPtr;
        public IntPtr CreateStateBlockPtr;
        public IntPtr SetClipStatusPtr;
        public IntPtr GetClipStatusPtr;
        public IntPtr GetTexturePtr;
        public IntPtr SetTexturePtr;
        public IntPtr GetTextureStageStatePtr;
        public IntPtr SetTextureStageStatePtr;
        public IntPtr ValidateDevicePtr;
        public IntPtr GetInfoPtr;
        public IntPtr SetPaletteEntriesPtr;
        public IntPtr GetPaletteEntriesPtr;
        public IntPtr SetCurrentTexturePalettePtr;
        public IntPtr GetCurrentTexturePalettePtr;
        public IntPtr DrawPrimitivePtr;
        public IntPtr DrawIndexedPrimitivePtr;
        public IntPtr DrawPrimitiveUPPtr;
        public IntPtr DrawIndexedPrimitiveUPPtr;
        public IntPtr ProcessVerticesPtr;
        public IntPtr CreateVertexShaderPtr;
        public IntPtr SetVertexShaderPtr;
        public IntPtr GetVertexShaderPtr;
        public IntPtr DeleteVertexShaderPtr;
        public IntPtr SetVertexShaderConstantPtr;
        public IntPtr GetVertexShaderConstantPtr;
        public IntPtr GetVertexShaderDeclarationPtr;
        public IntPtr GetVertexShaderFunctionPtr;
        public IntPtr SetStreamSourcePtr;
        public IntPtr GetStreamSourcePtr;
        public IntPtr SetIndicesPtr;
        public IntPtr GetIndicesPtr;
        public IntPtr CreatePixelShaderPtr;
        public IntPtr SetPixelShaderPtr;
        public IntPtr GetPixelShaderPtr;
        public IntPtr DeletePixelShaderPtr;
        public IntPtr SetPixelShaderConstantPtr;
        public IntPtr GetPixelShaderConstantPtr;
        public IntPtr GetPixelShaderFunctionPtr;
        public IntPtr DrawRectPatchPtr;
        public IntPtr DrawTriPatchPtr;
        public IntPtr DeletePatchPtr;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        unsafe public delegate Int32 EndScenePrototype(IDirect3DDevice8* device);

        public EndScenePrototype EndScene
        {
            get { return (EndScenePrototype)Marshal.GetDelegateForFunctionPointer(this.EndScenePtr, typeof(EndScenePrototype)); }
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        unsafe public delegate Int32 ClearPrototype(IDirect3DDevice8* device, Int32 count, D3DRECT* rects, D3DClear flags, Color color, Single z, Int32 stencil);

        public ClearPrototype Clear
        {
            get { return (ClearPrototype)Marshal.GetDelegateForFunctionPointer(this.ClearPtr, typeof(ClearPrototype)); }
        }
    }

    unsafe public struct D3DPRESENT_PARAMETERS
    {
        public UInt32 BackBufferWidth;
        public UInt32 BackBufferHeight;
        public IntPtr BackBufferFormat;
        public UInt32 BackBufferCount;
        public IntPtr MultiSampleType;
        public IntPtr MultiSampleQuality;
        public IntPtr SwapEffect;
        public IntPtr hDeviceWindow;
        public Byte Windowed;
        public Byte EnableAutoDepthStencil;
        public IntPtr AutoDepthStencilFormat;
        public IntPtr Flags;
        public UInt32 FullScreen_RefreshRateInHz;
        public UInt32 PresentationInterval;
    }

    unsafe public struct D3DRECT
    {
        public Int32 X1;
        public Int32 Y1;
        public Int32 X2;
        public Int32 Y2;
    }

    public enum D3DDeviceType : int
    {
        Hardware = 1,
        Reference = 2,
        Software = 3,
        NullReference = 4,
    }

    [Flags]
    public enum D3DCreate : int
    {
        FPUPreserve = 0x00000002,
        MultiThreaded = 0x00000004,
        PureDevice = 0x00000010,
        SoftwareVertexProcessing = 0x00000020,
        HardwareVertexProcessing = 0x00000040,
        MixedVertexProcessing = 0x00000080,
        DisableDriverManagement = 0x00000100
    }

    [Flags]
    public enum D3DClear : int
    {
        Target = 0x00000001,
        ZBuffer = 0x00000002,
        Stencil = 0x00000004,
        ComputeRects = 0x00000008,
    }
}
