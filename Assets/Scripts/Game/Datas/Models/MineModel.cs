using UnityEngine;

namespace Knights.Game
{
    public class MineModel : MeansModel
    {
        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            float value = 0;
            DataUtils.SetConfigValue(ref source, ref value, ref mMeansConfig.mine, "mine");
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