using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassItem
    {
        public static JassItem Create(JassObjectId itemid, Single x, Single y)
        {
            return SafeNatives.CreateItem(itemid, x, y);
        }

        public CItemPtr ToCItem()
        {
            return CItemPtr.FromHandle(this.Handle);
        }

        public void Remove()
        {
            SafeNatives.RemoveItem(this);
        }


        public JassObjectId GetTypeId()
        {
            return SafeNatives.GetItemTypeId(this);
        }

        public JassObjectId TypeId
        {
            get { return this.GetTypeId(); }
        }


        public JassPlayer GetPlayer()
        {
            return SafeNatives.GetItemPlayer(this);
        }

        public void SetPlayer(JassPlayer player, Boolean changeColor)
        {
            SafeNatives.SetItemPlayer(this, player, changeColor);
        }

        public void SetPlayer(JassPlayer player)
        {
            SafeNatives.SetItemPlayer(this, player, false);
        }

        public JassPlayer Player
        {
            get { return this.GetPlayer(); }
            set { this.SetPlayer(value); }
        }

        public Boolean IsOwned()
        {
            return SafeNatives.IsItemOwned(this);
        }

        public Boolean Owned
        {
            get { return this.IsOwned(); }
        }


        public Single GetX()
        {
            return SafeNatives.GetItemX(this);
        }

        public Single GetY()
        {
            return SafeNatives.GetItemY(this);
        }

        public void SetX(Single x)
        {
            this.SetPosition(x, this.GetY());
        }

        public void SetY(Single y)
        {
            this.SetPosition(this.GetX(), y);
        }

        public void SetPosition(Vector2 position)
        {
            this.SetPosition(position.X, position.Y);
        }

        public void SetPosition(Single x, Single y)
        {
            SafeNatives.SetItemPosition(this, x, y);
        }

        public Vector2 GetPosition()
        {
            return new Vector2(this.GetX(), this.GetY());
        }

        public Single X
        {
            get { return this.GetX(); }
            set { this.SetX(value); }
        }

        public Single Y
        {
            get { return this.GetY(); }
            set { this.SetY(value); }
        }


        public Boolean IsInvulnerable()
        {
            return SafeNatives.IsItemInvulnerable(this);
        }

        public void SetInvulnerable(Boolean flag)
        {
            SafeNatives.SetItemInvulnerable(this, flag);
        }

        public Boolean Invulnerable
        {
            get { return this.IsInvulnerable(); }
            set { this.SetInvulnerable(value); }
        }


        public Boolean IsPawnable()
        {
            return SafeNatives.IsItemPawnable(this);
        }

        public void SetPawnable(Boolean flag)
        {
            SafeNatives.SetItemPawnable(this, flag);
        }

        public Boolean Pawnable
        {
            get { return this.IsPawnable(); }
            set { this.SetPawnable(value); }
        }


        public Boolean IsVisible()
        {
            return SafeNatives.IsItemVisible(this);
        }

        public void SetVisible(Boolean flag)
        {
            SafeNatives.SetItemVisible(this, flag);
        }

        public Boolean Visible
        {
            get { return this.IsVisible(); }
            set { this.SetVisible(value); }
        }


        public Int32 GetCharges()
        {
            return SafeNatives.GetItemCharges(this);
        }

        public void SetCharges(Int32 charges)
        {
            SafeNatives.SetItemCharges(this, charges);
        }

        public Int32 Charges
        {
            get { return this.GetCharges(); }
            set { this.SetCharges(value); }
        }


        public Int32 GetUserData()
        {
            return SafeNatives.GetItemUserData(this);
        }

        public void SetUserData(Int32 charges)
        {
            SafeNatives.SetItemUserData(this, charges);
        }

        public Int32 UserData
        {
            get { return this.GetUserData(); }
            set { this.SetUserData(value); }
        }


        public String GetName()
        {
            return SafeNatives.GetItemName(this);
        }

        public String Name
        {
            get { return this.GetName(); }
        }


        public Int32 GetLevel()
        {
            return SafeNatives.GetItemLevel(this);
        }

        public Int32 Level
        {
            get { return this.GetLevel(); }
        }


        public JassItemType GetItemType()
        {
            return SafeNatives.GetItemType(this);
        }

        public JassItemType ItemType
        {
            get { return this.GetItemType(); }
        }


        public Boolean IsPowerup()
        {
            return SafeNatives.IsItemPowerup(this);
        }

        public Boolean Powerup
        {
            get { return this.IsSellable(); }
        }



        public Boolean IsSellable()
        {
            return SafeNatives.IsItemSellable(this);
        }

        public Boolean Sellable
        {
            get { return this.IsSellable(); }
        }


        public void SetDropOnDeath(Boolean flag)
        {
            SafeNatives.SetItemDropOnDeath(this, flag);
        }

        public void SetDroppable(Boolean flag)
        {
            SafeNatives.SetItemDroppable(this, flag);
        }

        public void SetDropID(JassObjectId unitId)
        {
            SafeNatives.SetItemDropID(this, unitId);
        }

        /*
            native          IsItemIdPowerup takes integer itemId returns boolean
            native          IsItemIdSellable takes integer itemId returns boolean
            native          IsItemIdPawnable takes integer itemId returns boolean
            native          EnumItemsInRect     takes rect r, boolexpr filter, code actionFunc returns nothing
         */
    }
}
