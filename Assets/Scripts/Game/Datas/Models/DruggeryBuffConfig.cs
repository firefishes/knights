using ShipDock.Framework.ObjectPool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipDock.Framework.Interfaces;

namespace Knights.Game
{
    public class DruggeryModel : GameModel
    {

        private DruggeryBuffConfig mDruggeryConfig;

        protected JSONObject mRawRoleCopy;
        protected JSONObject mRawDebuffCopy;

        protected override IGameModel GetNewModel()
        {
            return Pooling<DruggeryModel>.From();
        }

        protected override void CopyRaw()
        {
            base.CopyRaw();

            CheckRawCopy(ref mRawRoleCopy);
            CheckRawCopy(ref mRawDebuffCopy);
            
            KnightBattleConfig battleConf = mDruggeryConfig.buffBattle;
            mRawCopy.AddField("potential", battleConf.potential);
            mRawCopy.AddField("hp", battleConf.hp);
            mRawCopy.AddField("mp", battleConf.mp);
            mRawCopy.AddField("selfHealing", battleConf.selfHealing);
            mRawCopy.AddField("qi", battleConf.qi);
            mRawCopy.AddField("internalForce", battleConf.internalForce);
            mRawCopy.AddField("eyesight", battleConf.eyesight);
            mRawCopy.AddField("hearing", battleConf.hearing);
            mRawCopy.AddField("swordBreath", battleConf.swordBreath);
            mRawCopy.AddField("bodilyMovement", battleConf.bodilyMovement);
            mRawCopy.AddField("charm", battleConf.charm);
            mRawCopy.AddField("fate", battleConf.fate);

            mRawRoleCopy.AddField("fingerForce", battleConf.fingerForce);
            mRawRoleCopy.AddField("tough", battleConf.tough);
            mRawRoleCopy.AddField("physique", battleConf.physique);
            mRawRoleCopy.AddField("breath", battleConf.breath);
            mRawRoleCopy.AddField("acupoint", battleConf.acupoint);
            mRawRoleCopy.AddField("concentrate", battleConf.concentrate);
            mRawRoleCopy.AddField("antitoxic", battleConf.antitoxic);

            mRawDebuffCopy.AddField("debuffTrauma", battleConf.debuffTrauma);
            mRawDebuffCopy.AddField("debuffInternalInjury", battleConf.debuffInternalInjury);
            mRawDebuffCopy.AddField("debuffVertigo", battleConf.debuffVertigo);
            mRawDebuffCopy.AddField("debuffAcupointHit", battleConf.debuffAcupointHit);
            mRawDebuffCopy.AddField("debuffHorror", battleConf.debuffHorror);
            mRawDebuffCopy.AddField("debuffToxic", battleConf.debuffToxic);
            
        }

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);
            
        }

        public override int ModelType
        {
            get
            {
                return Consts.TYPE_DRUGGERY;
            }
        }

        //public DruggeryBuffConfig DruggeryCompose
        //{
        //    get
        //    {
        //        return mDruggeryConfig;
        //    }
        //}
    }

}