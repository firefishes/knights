using System;
using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 装备数据
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/EquipmentConfig")]
    public class EquipmentConfig : ItemConfig, IEquipmentConfig
    {
        /// <summary>装备部位</summary>
        public int equipType = 0;
        /// <summary>武术</summary>
        public float atk = 0;
        /// <summary>护体</summary>
        public float def = 0;
        /// <summary>培固</summary>
        public float strenthen = 0;
        /// <summary>助气</summary>
        public float assistQi = 0;
        /// <summary>冷峻</summary>
        public float frosty = 0;
        /// <summary>轻巧</summary>
        public float lightness = 0;
        /// <summary>雅致</summary>
        public float elegant = 0;
        /// <summary>神秘</summary>
        public float mystery = 0;
        /// <summary>指力</summary>
        public float fingerForce = 0;
        /// <summary>抗毒</summary>
        public float antitoxic = 0;
        /// <summary>当前耐力</summary>
        public float endurance = 0;
        /// <summary>耐力最大值</summary>
        public float enduranceMax = 0;

        public virtual void InitEquipmentConfig(ref JSONObject source)
        {
            InitItem(ref source);

            float value = 0;
            source.GetField(ref equipType, "equip_type");

            DataUtils.SetConfigValue(ref source, ref value, ref atk, "atk");
            DataUtils.SetConfigValue(ref source, ref value, ref def, "def");
            DataUtils.SetConfigValue(ref source, ref value, ref strenthen, "strenthen");
            DataUtils.SetConfigValue(ref source, ref value, ref assistQi, "assist_qi");
            DataUtils.SetConfigValue(ref source, ref value, ref frosty, "frosty");
            DataUtils.SetConfigValue(ref source, ref value, ref elegant, "elegant");
            DataUtils.SetConfigValue(ref source, ref value, ref fingerForce, "finger_force");
            DataUtils.SetConfigValue(ref source, ref value, ref antitoxic, "antitoxic");
            DataUtils.SetConfigValue(ref source, ref value, ref enduranceMax, "endurance_max");

            endurance = enduranceMax;

        }
    }

    public interface IEquipmentConfig : INamableItem, IScriptableItem
    {
        void InitEquipmentConfig(ref JSONObject source);
    }
}