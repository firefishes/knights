using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 武学数据模型类
    /// 
    /// add by Minghua.ji
    /// 
    /// </summary>
    public class MartialArtModel : GameModel
    {

        protected MartialArtsConfig martialArtsConfig;

        public MartialArtModel() : base()
        {

        }

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            martialArtsConfig = ScriptableObject.CreateInstance<MartialArtsConfig>();
            martialArtsConfig.InitMartialArtsConfig(ref source);
        }

        public MartialArtsConfig MartialArtsCompose
        {
            get
            {
                return martialArtsConfig;
            }
        }

        public override int ModelType
        {
            get
            {
                return Consts.MODEL_MARTIAL_ART;
            }
        }
    }

}