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

            JSONObject bookRaw = source["book"];
            mBookConfig.InitBookConfig(ref bookRaw);
        }
    }

}