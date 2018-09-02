using ShipDock.Framework.Data.Models;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.ObjectPool;
using System.Text;
using System;

namespace Knights.Game
{
    public interface IGameModel
    {
        void InitModel(ref JSONObject source);
        int ID { get; }
        int NameID { get; }
        int ModelType { get; }
        string Name { get; }
    }
    
    public class GameModel : Model, IGameModel, IPoolItem, INamableItem
    {
        protected StringBuilder mSbd;
        protected JSONObject mRawCopy;

        public GameModel()
        {

        }

        public virtual void Revert()
        {
            if(mSbd != null)
            {
                mSbd.Length = 0;
            }
            mSbd = null;
        }

        public override void Copy(out IModel result, IModel rawModel = null)
        {
            CopyRaw();

            IGameModel target = GetNewModel();
            target.InitModel(ref mRawCopy);
            result = target as IModel;
        }

        protected virtual IGameModel GetNewModel()
        {
            return Pooling<GameModel>.From() as IGameModel;
        }

        protected virtual void CopyRaw()
        {
            CheckRawCopy(ref mRawCopy);

            //mRawCopy.AddField("name_id", mNameID);
            //mRawCopy.AddField("name", mName);
        }

        protected void CheckRawCopy(ref JSONObject rawJSON)
        {
            if (rawJSON != null)
            {
                rawJSON.Clear();
            }
            else
            {
                rawJSON = JSONObject.Create(JSONObject.Type.OBJECT);
            }
        }

        public virtual void InitModel(ref JSONObject source)
        {
            mRawCopy = source;
            //source.GetField(ref mNameID, "name_id");
            //source.GetField(ref mName, "name");
        }

        public override void Dispose()
        {
            mRawCopy = null;
        }

        public void SetName(ref string value)
        {
            //mName = value;
        }

        public void SetNameID(int value)
        {
            //mNameID = value;
        }

        public override int ModelType
        {
            get
            {
                return Consts.MODEL_BASE;
            }
        }

        public virtual int ID
        {
            get
            {
                return int.MaxValue;
            }
        }

        public virtual int NameID
        {
            get
            {
                return int.MaxValue;
            }
        }

        public virtual string Name
        {
            get
            {
                return string.Empty;
            }
        }
    }
}
