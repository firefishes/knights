using UnityEngine;

namespace Knights.Game
{
    public class MeansModel : ItemModel
    {
        protected KnightMeansConfig mMeansConfig;

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            mItemConfig = ScriptableObject.CreateInstance<ItemConfig>();
            mMeansConfig = ScriptableObject.CreateInstance<KnightMeansConfig>();

            mItemConfig.InitItem(ref source);

            float value = 0;
            DataUtils.SetConfigValue(ref source, ref value, ref mMeansConfig.gold, "gold");
            DataUtils.SetConfigValue(ref source, ref value, ref mMeansConfig.silk, "silk");
            DataUtils.SetConfigValue(ref source, ref value, ref mMeansConfig.toxin, "toxin");
        }

        public KnightMeansConfig MeansConfigCompose
        {
            get
            {
                return mMeansConfig;
            }
        }
    }

}