using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 基础配置
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/KnightBaseConfig")]
    public class KnightBaseConfig : ScriptableItem
    {
        /// <summary>姓</summary>
        public string firstName;
        /// <summary>名</summary>
        public string secendName;
        /// <summary>绰号</summary>
        public string thirdName;
        /// <summary>性别</summary>
        public int sexuality;
        /// <summary>正邪</summary>
        public float evilOrJustice;
        /// <summary>威望</summary>
        public float prestige;
        /// <summary>师承</summary>
        public int master;
        /// <summary>门派</summary>
        public int sect;

        public void InitBaseConfig(ref JSONObject source)
        {
            SetRaw(ref source);

            float value = 0;
            source.GetField(ref id, "id");
            source.GetField(ref firstName, "fir_name");
            source.GetField(ref secendName, "sec_name");
            source.GetField(ref thirdName, "thr_name");
            source.GetField(ref sexuality, "sexuality");

            source.GetField(ref value, "evilOrJustice");
            evilOrJustice = value / 1000;
            source.GetField(ref value, "prestige");
            prestige = value / 1000;
            source.GetField(ref master, "master");
            source.GetField(ref sect, "sect");
        }

    }

}