using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 武学配置
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/MartialArtsConfig")]
    public class MartialArtsConfig : ScriptableObject
    {
        /// <summary>数据id</summary>
        public int id;
        /// <summary>类型</summary>
        public int type;
        /// <summary>武学名称</summary>
        public string martialArtsName;
        /// <summary>载体</summary>
        public int carrier;
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
    }

}