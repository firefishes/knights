using UnityEngine;

namespace Knights.Game
{
    public class BookModel : ItemModel
    {
        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            BookConfig config = ScriptableObject.CreateInstance<BookConfig>();
            mItemConfig = config;
        }
    }

}