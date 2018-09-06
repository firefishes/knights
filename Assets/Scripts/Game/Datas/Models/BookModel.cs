using UnityEngine;

namespace Knights.Game
{
    public class BookModel : ItemModel
    {
        protected BookConfig mBookConfig;

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            mItemConfig = ScriptableObject.CreateInstance<ItemConfig>();
            mBookConfig = ScriptableObject.CreateInstance<BookConfig>();

            mItemConfig.InitItem(ref source);

            int value = 0;
            DataUtils.SetConfigValue(ref source, ref value, ref mBookConfig.martialArtID, "martial_art_id");
            DataUtils.SetConfigValue(ref source, ref value, ref mBookConfig.carrier, "carrier");
        }
    }

}