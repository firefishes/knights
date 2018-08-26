using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 兵刃数据
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/WeaponConfig")]
    public class WeaponConfig : EquipmentConfig
    {
        /// <summary>兵刃类型</summary>
        public int weaponType = 0;
        /// <summary>质地</summary>
        public int stuffType = 0;
        /// <summary>是否双持</summary>
        public bool isDoubleHolding = false;
        /// <summary>锋锐</summary>
        public float sharp = 0;
        /// <summary>沉重</summary>
        public float heavy = 0;
        /// <summary>精准</summary>
        public float precise = 0;
        /// <summary>诡异</summary>
        public float strange = 0;
        /// <summary>剧毒</summary>
        public float toxic = 0;
        /// <summary>格挡</summary>
        public float shoveAside = 0;
        /// <summary>柔韧</summary>
        public float pliable = 0;
        /// <summary>封锁</summary>
        public float blockade = 0;
        /// <summary>锻铸</summary>
        public int forgedCasting = 0;
        /// <summary>坚利</summary>
        public int firm = 0;
    }

}