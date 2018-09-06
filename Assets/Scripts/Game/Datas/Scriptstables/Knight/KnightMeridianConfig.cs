using UnityEngine;
using System;

namespace Knights.Game
{
    /// <summary>
    /// 经脉配置
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/KnightMeridianConfig")]
    public class KnightMeridianConfig : ScriptableItem
    {
        public KnightMeridian data;

        protected override IScriptableItem GetNewConfig()
        {
            return CreateInstance<KnightMeridianConfig>() as IScriptableItem;
        }

        public override IScriptableItem Copy()
        {
            IScriptableItem config = base.Copy();

            KnightMeridianConfig target = config as KnightMeridianConfig;
            target.InitMeridianConfig(ref mRawJSON);
            target.data.meridian = data.meridian;
            target.data.meridianYin = data.meridianYin;
            target.data.meridianYang = data.meridianYang;
            target.data.meridianHard = data.meridianHard;
            target.data.meridianSoft = data.meridianSoft;
            target.data.meridianToxin = data.meridianToxin;

            return config;
        }

        public void InitMeridianConfig(ref JSONObject source)
        {
            SetRaw(ref source);

            if(data == null)
            {
                data = new KnightMeridian();
            }

            DataUtils.SetKnightMeridian(ref source, ref data);
        }
    }
    
    [Serializable]
    public class KnightMeridian
    {
        /// <summary>脉</summary>
        public float meridian = 0;
        /// <summary>阴</summary>
        public float meridianYin = 0;
        /// <summary>阳</summary>
        public float meridianYang = 0;
        /// <summary>刚</summary>
        public float meridianHard = 0;
        /// <summary>柔</summary>
        public float meridianSoft = 0;
        /// <summary>毒</summary>
        public float meridianToxin = 0;
    }
}