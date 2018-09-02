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

        public override void InitEquipmentConfig(ref JSONObject source)
        {
            base.InitEquipmentConfig(ref source);

            JSONObject hiddenWeaponRaw = source["hidden_weapon"];
            InitHiddenWeaponConfig(ref hiddenWeaponRaw);

        }

        private void InitHiddenWeaponConfig(ref JSONObject source)
        {
            int value = 0;

            DataUtils.SetConfigValue(ref source, ref value, ref techniqueID, "technique_id");
            DataUtils.SetConfigValue(ref source, ref value, ref apparatusID, "apparatus_id");
            DataUtils.SetConfigValue(ref source, ref value, ref range, "range");
        }
    }

}