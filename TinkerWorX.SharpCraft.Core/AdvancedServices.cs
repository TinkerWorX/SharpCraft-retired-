using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Core
{
    public static class AdvancedServices
    {
        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Int32 OpenProcessToken(IntPtr ProcessHandle, Int32 DesiredAccess, ref Int32 tokenhandle);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern Int32 GetCurrentProcess();

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Int32 LookupPrivilegeValue(String lpsystemname, String lpname, ref Int64 lpLuid);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Int32 AdjustTokenPrivileges(Int32 tokenhandle, Int32 disableprivs, ref TOKEN_PRIVILEGES Newstate, Int32 bufferlength, Int32 PreivousState, Int32 Returnlength);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Int32 GetSecurityInfo(IntPtr HANDLE, Int32 SE_OBJECT_TYPE, Int32 SECURITY_INFORMATION, Int32 psidOwner, Int32 psidGroup, out IntPtr pDACL, IntPtr pSACL, out IntPtr pSecurityDescriptor);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Int32 SetSecurityInfo(IntPtr HANDLE, Int32 SE_OBJECT_TYPE, Int32 SECURITY_INFORMATION, Int32 psidOwner, Int32 psidGroup, IntPtr pDACL, IntPtr pSACL);
    }
}
