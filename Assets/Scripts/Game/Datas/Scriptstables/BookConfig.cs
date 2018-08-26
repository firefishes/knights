using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 书籍数据
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/BookConfig")]
    public class BookConfig : ItemConfig
    {
        public MartialArtsConfig martialArtsConfig;
    }

}