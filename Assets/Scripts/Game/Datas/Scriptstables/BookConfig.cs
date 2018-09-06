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
        
    }

}