using System;
using UnityEngine;

namespace Knights.Game
{
    public class KnightModel : GameModel
    {
        /// <summary>是否为玩家</summary>
        protected bool mIsPlayer;
        /// <summary>基础数据</summary>
        protected KnightBaseConfig mBaseConfig;
        /// <summary>经脉数据</summary>
        protected KnightMeridianConfig mMeridianConfig;
        /// <summary>战斗数据</summary>
        protected KnightBattleConfig mBattleConfig;

        private int mNameID;
        private string mName;

        public KnightModel()
        {

        }

        public override void Revert()
        {
            base.Revert();
            
            mBaseConfig = null;
        }

        public override void Dispose()
        {

        }

        protected override void CopyRaw()
        {
            base.CopyRaw();


        }

        override public void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            if(!mIsPlayer)
            {
                mBaseConfig = ScriptableObject.CreateInstance<KnightBaseConfig>();
                mMeridianConfig = ScriptableObject.CreateInstance<KnightMeridianConfig>();
                mBattleConfig = ScriptableObject.CreateInstance<KnightBattleConfig>();
                
                mBaseConfig.InitBaseConfig(ref source);
                mMeridianConfig.InitMeridianConfig(ref source);
                mBattleConfig.InitBattleConfig(ref source);

                mNameID = -1;
                mName = mBaseConfig.firstName.Append(ref mSbd, mBaseConfig.secendName);
            }
        }

        public KnightBaseConfig BaseCompose
        {
            get
            {
                return mBaseConfig;
            }
        }

        public KnightMeridian MeridianCompose
        {
            get
            {
                return mMeridianConfig.data;
            }
        }

        public KnightBattleConfig BattleCompose
        {
            get
            {
                return mBattleConfig;
            }
        }

        public bool IsPlayer
        {
            get
            {
                return mIsPlayer;
            }
        }

        override public int ID
        {
            get
            {
                return (mBaseConfig != null) ? mBaseConfig.id : base.ID;
            }
        }

        public override int ModelType
        {
            get
            {
                return Consts.MODEL_KNIGHT;
            }
        }

        public override string Name
        {
            get
            {
                return mName;
            }
        }

        public override int NameID
        {
            get
            {
                return base.NameID;
            }
        }
    }

}