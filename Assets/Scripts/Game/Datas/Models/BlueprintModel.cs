using ShipDock.Framework.ObjectPool;
using UnityEngine;

namespace Knights.Game
{
    public class BlueprintModel : GameModel
    {

        private BlueprintConfig mBlueprintConfig;

        public BlueprintModel()
        {

        }

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            mBlueprintConfig = ScriptableObject.CreateInstance<BlueprintConfig>();

            source.GetField(ref mBlueprintConfig.medicine, "medicine");
            source.GetField(ref mBlueprintConfig.mine, "mine");
            source.GetField(ref mBlueprintConfig.silk, "silk");
            source.GetField(ref mBlueprintConfig.toxin, "toxin");
        }

        protected override IGameModel GetNewModel()
        {
            return Pooling<BlueprintModel>.From();
        }

        protected override void CopyRaw()
        {
            base.CopyRaw();

            mRawCopy.AddField("medicine", mBlueprintConfig.medicine);
            mRawCopy.AddField("mine", mBlueprintConfig.mine);
            mRawCopy.AddField("silk", mBlueprintConfig.silk);
            mRawCopy.AddField("toxin", mBlueprintConfig.toxin);
        }

        public override int ID
        {
            get
            {
                return (mBlueprintConfig != null) ? mBlueprintConfig.id : base.ID;
            }
        }

        public BlueprintConfig BlueprintConfigCompose
        {
            get
            {
                return mBlueprintConfig;
            }
        }

        public override int ModelType
        {
            get
            {
                return base.ModelType;
            }
        }
    }

}