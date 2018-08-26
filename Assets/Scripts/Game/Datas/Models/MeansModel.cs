using UnityEngine;

namespace Knights.Game
{
    public class MeansModel : ItemModel
    {
        private KnightMeansConfig mMeansConfig;

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            mItemConfig = ScriptableObject.CreateInstance<ItemConfig>();
            mMeansConfig = ScriptableObject.CreateInstance<KnightMeansConfig>();
        }
    }

}