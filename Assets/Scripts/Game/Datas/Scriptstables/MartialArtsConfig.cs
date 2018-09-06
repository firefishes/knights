using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 武学配置
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/MartialArtsConfig")]
    public class MartialArtsConfig : ScriptableItem
    {
        /// <summary>数据id</summary>
        public int id;
        /// <summary>类型</summary>
        public int type;
        /// <summary>武学名称</summary>
        public string martialArtsName;
        /// <summary>攻击</summary>
        public float atk;
        /// <summary>守御</summary>
        public float def;
        /// <summary>精妙</summary>
        public float ingenious;
        /// <summary>步法</summary>
        public float gait;
        /// <summary>结阵</summary>
        public float tactical;
        /// <summary>气耗</summary>
        public float qiCost;
        /// <summary>招式</summary>
        public float series;
        /// <summary>心法</summary>
        public float knack;
        /// <summary>致命</summary>
        public float fatal;
        /// <summary>极限</summary>
        public int levelMax;
        /// <summary>兵刃类型</summary>
        public int weaponType;
        /// <summary>修炼</summary>
        public KnightAttainments attainments;
        /// <summary>经脉</summary>
        public KnightMeridian meridians;

        private JSONObject meridiansRaw;
        private JSONObject attainmentsRaw;

        public void InitMartialArtsConfig(ref JSONObject source)
        {
            float value = 0;
            int valueInt = 0;
            string valueString = string.Empty;

            DataUtils.SetConfigValue(ref source, ref valueString, ref martialArtsName, "name");

            DataUtils.SetConfigValue(ref source, ref valueInt, ref id, "id");
            DataUtils.SetConfigValue(ref source, ref valueInt, ref type, "type");
            DataUtils.SetConfigValue(ref source, ref valueInt, ref levelMax, "levelMax");
            DataUtils.SetConfigValue(ref source, ref valueInt, ref weaponType, "weaponType");

            DataUtils.SetConfigValue(ref source, ref value, ref atk, "atk");
            DataUtils.SetConfigValue(ref source, ref value, ref def, "def");
            DataUtils.SetConfigValue(ref source, ref value, ref ingenious, "ingenious");
            DataUtils.SetConfigValue(ref source, ref value, ref gait, "gait");
            DataUtils.SetConfigValue(ref source, ref value, ref tactical, "tactical");
            DataUtils.SetConfigValue(ref source, ref value, ref qiCost, "qiCost");
            DataUtils.SetConfigValue(ref source, ref value, ref series, "series");
            DataUtils.SetConfigValue(ref source, ref value, ref knack, "knack");
            DataUtils.SetConfigValue(ref source, ref value, ref fatal, "fatal");

            meridiansRaw = source["meridians"];
            meridians = new KnightMeridian();
            DataUtils.SetKnightMeridian(ref meridiansRaw, ref meridians);

            attainmentsRaw = source["attainments"];
            attainments = new KnightAttainments();
            DataUtils.SetKnightAttainments(ref attainmentsRaw, ref attainments);
        }
    }

}