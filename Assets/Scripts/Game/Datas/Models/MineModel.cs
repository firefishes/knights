using UnityEngine;

namespace Knights.Game
{
    public class MineModel : ItemModel
    {
        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            MineConfig mineConfig = ScriptableObject.CreateInstance<MineConfig>();
            mItemConfig = mineConfig;
        }

        public override int ModelType
        {
            get
            {
                return Consts.MODEL_MINE;
            }
        }
    }

}