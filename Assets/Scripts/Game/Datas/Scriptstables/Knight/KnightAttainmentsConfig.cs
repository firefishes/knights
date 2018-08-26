using UnityEngine;
using System;

namespace Knights.Game
{
    /// <summary>
    /// 造诣配置
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/KnightAttainmentsConfig")]
    public class KnightAttainmentsConfig : ScriptableObject
    {
        public KnightAttainments data;
    }

    [Serializable]
    public class KnightAttainments
    {
        /// <summary>拳脚</summary>
        public float fist = 0;
        /// <summary>兵刃</summary>
        public float blade = 0;
        /// <summary>外功</summary>
        public float meritExternal = 0;
        /// <summary>内功</summary>
        public float meritInternal = 0;
        /// <summary>毒功</summary>
        public float meritToxin = 0;
        /// <summary>轻功</summary>
        public float meritDodge = 0;
        /// <summary>暗器</summary>
        public float meritDarkarm = 0;
        /// <summary>医术</summary>
        public float meritMedical = 0;
        /// <summary>学识</summary>
        public float meritKnowledge = 0;
    }
}
