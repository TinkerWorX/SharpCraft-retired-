using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using TinkerWorX.Blizzard;
using TinkerWorX.Blizzard.GameModule.Jass;
using TinkerWorX.Blizzard.GameModule.Types;
using TinkerWorX.Blizzard.Types;
using TinkerWorX.SharpCraft.Plugins;
using TinkerWorX.Utilities;

namespace TinkerWorX.ExamplePlugin
{
    unsafe public class ExamplePlugin : FullPluginBase
    {
        public override String Name { get { return "The Example Plugin"; } }

        public override Version Version { get { return new Version(0, 0, 0, 0); } }

        public override void OnCheat(String str)
        {
            const String prefix = "mindworx.example: ";
            if (!str.StartsWith(prefix)) return;
            str = str.Remove(0, prefix.Length);

            switch (str)
            {
                case "mapinit": this.MapInit(); break;
                case "tick": this.Tick(); break;
                case "esc": this.ESC(); break;
                case "instantorder": this.InstantOrder(); break;
                case "pointorder": this.PointOrder(); break;
                case "targetorder": this.TargetOrder(); break;
                case "begincast": this.BeginCast(); break;
            }
        }

        private void Print(String text)
        {
            Native.DisplayTimedTextToPlayer(Native.GetLocalPlayer(), 0.00f, 0.00f, 10.00f, text);
        }

        public void MapInit()
        {
            try
            {
                JassUnit.Create(JassPlayer.FromIndex(0), (JassObjectId)"htow", 0, 0, 0);
                JassUnit.Create(JassPlayer.FromIndex(0), (JassObjectId)"hpea", 0, 0, 0);
                JassUnit.Create(JassPlayer.FromIndex(0), (JassObjectId)"hpea", 0, 0, 0);
                JassUnit.Create(JassPlayer.FromIndex(0), (JassObjectId)"hfoo", 0, 0, 0);
                JassUnit.Create(JassPlayer.FromIndex(0), (JassObjectId)"hgyr", 0, 0, 0);
                JassUnit.Create(JassPlayer.FromIndex(0), (JassObjectId)"hgyr", 0, 0, 0);
                JassUnit.Create(JassPlayer.FromIndex(0), (JassObjectId)"Hpal", 0, 0, 0);
                JassItem.Create((JassObjectId)"ofir", 0, 0);
                var priest1 = JassUnit.Create(JassPlayer.FromIndex(0), (JassObjectId)"hmpr", 0, 0, 0).ToCUnit().AsUnsafe();
                var priest2 = JassUnit.Create(JassPlayer.FromIndex(0), (JassObjectId)"hmpr", 0, 0, 0).ToCUnit().AsUnsafe();
                var heal = new JassObjectId("Ahea");

                // We need to fetch ability from both units since they're unique to each unit.
                var ability1 = priest1->GetAbility(heal);
                var ability2 = priest2->GetAbility(heal);

                // We then make the data for each ability unique.
                ability1->MakeDataUnique();
                ability2->MakeDataUnique();

                // We can now set stats indedependantly for each unit.
                ability1->Data->Level[0].ManaCost = 1;
                ability1->Data->Level[0].SetDataA(10.00f);
                ability2->Data->Level[0].ManaCost = 2;
                ability2->Data->Level[0].SetDataA(20.00f);
            }
            catch (Exception e)
            {
                Console.WriteLine(this.Name + ": " + e.GetType().Name + " in MapInit: " + e.Message);
            }
        }

        public void Tick()
        {
            try
            {
                //Native.DisplayTimedTextToPlayer(Native.GetLocalPlayer(), 0, 0, 0, Input.MouseTerrain.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(this.Name + ": " + e.GetType().Name + " in Tick: " + e.Message);
            }
        }

        public void ESC()
        {
            try
            {
                //var unit = JassUnit.Create(JassPlayer.FromIndex(0), (JassObjectId)"hmpr", 0.00f, 0.00f, 0.00f).ToCUnit().AsUnsafe();

            }
            catch (Exception e)
            {
                Console.WriteLine(this.Name + ": " + e.GetType().Name + " in ESC: " + e.Message);
            }
        }

        public void InstantOrder()
        {
            try
            {
                var unit = Native.GetOrderedUnit();
                var order = Native.GetIssuedOrderId();
                var unitName = Native.GetUnitName(unit);
                if (order == JassOrder.stop)
                {
                    var cunit = Native.GetOrderedUnit().ToCUnit().AsUnsafe();
                    Print(unitName + "(" + new IntPtr(cunit).ToString("X8") + ")");
                    var attack = cunit->GetAttackAbility();
                    Print(attack->GetClassName() + "(" + new IntPtr(attack).ToString("X8") + ")");
                    Print(attack->cool1 + ", " + attack->dmgplus1 + ", " + attack->dice1 + ", " + attack->sides1 + ", " + attack->rangeN1 + ", " + attack->dmgbonus1 + ", ...");
                    Print(attack->cool2 + ", " + attack->dmgplus2 + ", " + attack->dice2 + ", " + attack->sides1 + ", " + attack->rangeN2 + ", " + attack->dmgbonus2 + ", ...");

                    /*foreach (var abilityPtr in cunit->GetAllAbilities())
                    {
                        var ability = abilityPtr.AsUnsafe();
                        Print(" - " + ability->GetClassName() + ":" + ability->GetClassId());
                    }*/
                    //Print("field0010(" + cunit->field000C.ToString("X4") + "):" + CUnit.sub_6F4786B0(&cunit->field000C).ToString("X8"));
                    //Print("field00A0(" + cunit->field00A0.ToString("X4") + "):" + CUnit.sub_6F4786B0(&cunit->field00A0).ToString("X8"));
                    //Print("field00C0(" + cunit->field00C0.ToString("X4") + "):" + CUnit.sub_6F4786B0(&cunit->field00C0).ToString("X8"));
                    //Print("field0104(" + cunit->field0104.ToString("X4") + "):" + CUnit.sub_6F4786B0(&cunit->field0104).ToString("X8"));
                    //Print("field0120(" + cunit->field0120.ToString("X4") + "):" + CUnit.sub_6F4786B0(&cunit->field0120).ToString("X8"));
                    //Print("field016C(" + cunit->field016C.ToString("X4") + "):" + CUnit.sub_6F4786B0(&cunit->field016C).ToString("X8"));
                    //Print("field01DC(" + cunit->field01DC.ToString("X4") + "):" + CUnit.sub_6F4786B0(&cunit->field01DC).ToString("X8"));
                    //Print("field021C(" + cunit->field021C.ToString("X4") + "):" + CUnit.sub_6F4786B0(&cunit->field021C).ToString("X8"));
                }
                //Console.WriteLine(name + " was issued the instant order " + order);
            }
            catch (Exception e)
            {
                Console.WriteLine(this.Name + ": " + e.GetType().Name + " in InstantOrder: " + e.Message);
            }
        }

        public void PointOrder()
        {
            try
            {
                var unit = Native.GetOrderedUnit();
                var order = Native.GetIssuedOrderId();
                var name = Native.GetUnitName(unit);
                //Console.WriteLine(name + " was issued the point order " + order);
            }
            catch (Exception e)
            {
                Console.WriteLine(this.Name + ": " + e.GetType().Name + " in PointOrder: " + e.Message);
            }
        }

        public void TargetOrder()
        {
            try
            {
                var unit = Native.GetOrderedUnit();
                var order = Native.GetIssuedOrderId();
                var name = Native.GetUnitName(unit);
                //Console.WriteLine(name + " was issued the target order " + order);
            }
            catch (Exception e)
            {
                Console.WriteLine(this.Name + ": " + e.GetType().Name + " in TargetOrder: " + e.Message);
            }
        }

        public void BeginCast()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(this.Name + ": " + e.GetType().Name + " in BeginCast: " + e.Message);
            }
        }
    }
}
