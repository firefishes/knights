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
        public float forgedCasting = 0;
        /// <summary>坚利</summary>
        public float firm = 0;

        public override void InitEquipmentConfig(ref JSONObject source)
        {
            base.InitEquipmentConfig(ref source);

            InitWeaponConfig(ref source);

        }

        private void InitWeaponConfig(ref JSONObject source)
        {
            JSONObject weaponRaw = source["weapon"];
            
            float value = 0;
            int valueInt = 0;

            DataUtils.SetConfigValue(ref weaponRaw, ref isDoubleHolding, "is_double_holding");
            DataUtils.SetConfigValue(ref weaponRaw, ref valueInt, ref weaponType, "weapon_type");
            DataUtils.SetConfigValue(ref weaponRaw, ref valueInt, ref stuffType, "stuff_type");
            DataUtils.SetConfigValue(ref weaponRaw, ref value, ref sharp, "sharp");
            DataUtils.SetConfigValue(ref weaponRaw, ref value, ref heavy, "heavy");
            DataUtils.SetConfigValue(ref weaponRaw, ref value, ref precise, "precise");
            DataUtils.SetConfigValue(ref weaponRaw, ref value, ref strange, "strange");
            DataUtils.SetConfigValue(ref weaponRaw, ref value, ref toxic, "toxic");
            DataUtils.SetConfigValue(ref weaponRaw, ref value, ref shoveAside, "shove_aside");
            DataUtils.SetConfigValue(ref weaponRaw, ref value, ref pliable, "pliable");
            DataUtils.SetConfigValue(ref weaponRaw, ref value, ref blockade, "blockade");
            DataUtils.SetConfigValue(ref weaponRaw, ref value, ref forgedCasting, "forge_casting");
            DataUtils.SetConfigValue(ref weaponRaw, ref value, ref firm, "firm");
        }
    }

}