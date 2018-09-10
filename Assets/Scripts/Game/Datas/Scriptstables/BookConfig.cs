using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 书籍数据
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/BookConfig")]
    public class BookConfig : ScriptableItem
    {
        /// <summary>武学id</summary>
        public int martialArtID;
        /// <summary>载体</summary>
        public int carrier;
        
        public void InitBookConfig(ref JSONObject source)
        {
            SetRaw(ref source);

            int value = 0;
            DataUtils.SetConfigValue(ref source, ref value, ref martialArtID, "martial_art_id");
            DataUtils.SetConfigValue(ref source, ref value, ref carrier, "carrier");
        }
    }

}