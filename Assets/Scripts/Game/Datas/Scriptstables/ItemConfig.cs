using System;
using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 物品配置
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/ItemConfig")]
    public class ItemConfig : ScriptableItem, INamableItem
    {
        /// <summary>价值</summary>
        public int price = 0;
        /// <summary>名称本地化id</summary>
        public int nameID;

        protected string mName;

        public void InitItem(ref JSONObject source)
        {
            SetRaw(ref source);

            mRawJSON.GetField(ref price, "price");
            mRawJSON.GetField(ref nameID, "name_id");
        }

        public override IScriptableItem Copy()
        {
            ItemConfig config = GetNewConfig() as ItemConfig;
            config.nameID = nameID;
            config.price = price;
            return (config as IScriptableItem);
        }

        protected override IScriptableItem GetNewConfig()
        {
            return CreateInstance<ItemConfig>();
        }

        public virtual void SetName(ref string value)
        {
            mName = value;
        }

        public void SetNameID(int value)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get
            {
                return mName;
            }
        }

        public int NameID
        {
            get
            {
                return nameID;
            }
        }
    }

}