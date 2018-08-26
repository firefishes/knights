using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 资产配置
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/KnightMeansConfig")]
    public class KnightMeansConfig : ScriptableObject
    {
        /// <summary>金</summary>
        public float gold;
        /// <summary>矿</summary>
        public float mine;
        /// <summary>丝</summary>
        public float silk;
        /// <summary>药</summary>
        public float medicine;
        /// <summary>毒</summary>
        public float toxin;
    }
}