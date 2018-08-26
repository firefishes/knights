using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 暗器数据
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/HiddenWeaponConfig")]
    public class HiddenWeaponConfig : EquipmentConfig
    {
        /// <summary>杀伤</summary>
        //public float atk;
        /// <summary>手法</summary>
        public int techniqueID;
        /// <summary>所需器具</summary>
        public int apparatusID;
        /// <summary>距离</summary>
        public int range;
    }

}