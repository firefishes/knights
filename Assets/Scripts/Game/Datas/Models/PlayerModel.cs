namespace Knights.Game
{
    public class PlayerModel : KnightModel
    {
        /// <summary>玩家id</summary>
        private int mUID;
        /// <summary>资产数据</summary>
        private KnightMeansConfig mMeansConfig;
        /// <summary>造诣数据</summary>
        private KnightAttainmentsConfig mAttainmentsConfig;
        /// <summary>造诣最大值数据</summary>
        private KnightAttainmentsConfig mAttainmentsMaxConfig;

        public PlayerModel() : base()
        {
            mIsPlayer = true;
        }

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);
        }

        public void SetUID(ref int value)
        {
            mUID = value;
        }

        public void SetPlayerKnightConfig(ref KnightDataComponent component)
        {
            mBaseConfig = component.BaseData;
            mBattleConfig = component.BattleData;
            mMeansConfig = component.MeansData;
            mAttainmentsConfig = component.AttainmentsData;
            mAttainmentsMaxConfig = component.AttainmentsMaxData;
            mMeridianConfig = component.MeridianData;

        }
        
        public KnightMeansConfig MeansCompose
        {
            get
            {
                return mMeansConfig;
            }
        }

        public KnightAttainmentsConfig AttainmentsCompose
        {
            get
            {
                return mAttainmentsConfig;
            }
        }

        public KnightAttainmentsConfig AttainmentsMaxCompose
        {
            get
            {
                return mAttainmentsMaxConfig;
            }
        }

        public override int ModelType
        {
            get
            {
                return Consts.MODEL_PLAYER;
            }
        }

        public override int ID
        {
            get
            {
                return mUID;
            }
        }
    }

}