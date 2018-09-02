using System;
using ShipDock.Framework.Interfaces;
using UnityEngine;

namespace Knights.Game
{
    public class ScriptableItem : ScriptableObject, IScriptableItem
    {

        /// <summary>数据id</summary>
        public int id;

        protected JSONObject mRawJSON;

        protected void SetRaw(ref JSONObject raw)
        {
            if (mRawJSON == null)
            {
                mRawJSON = raw;
            }
            mRawJSON.GetField(ref id, "id");
        }

        public virtual IScriptableItem Copy()
        {
            ScriptableItem config = GetNewConfig() as ScriptableItem;
            config.id = id;
            return (config as IScriptableItem);
        }

        protected virtual IScriptableItem GetNewConfig()
        {
            return CreateInstance<ScriptableItem>();
        }

        public int GetItemID()
        {
            return id;
        }

        public virtual void Dispose()
        {
            mRawJSON = null;
        }
    }

    public interface IScriptableItem : IDispose
    {
        int GetItemID();
        IScriptableItem Copy();
    }

    public interface INamableItem
    {
        void SetName(ref string value);
        void SetNameID(int value);
        string Name { get; }
        int NameID { get; }
    }

}