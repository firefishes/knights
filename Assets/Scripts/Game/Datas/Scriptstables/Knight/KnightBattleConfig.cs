using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 人物战斗数据
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/KnightBattleConfig")]
    public class KnightBattleConfig : ScriptableItem
    {

        /// <summary>潜力</summary>
        public float potential;
        /// <summary>命</summary>
        public float hp;
        /// <summary>气</summary>
        public float mp;
        /// <summary>复元</summary>
        public float selfHealing;
        /// <summary>运功</summary>
        public float qi;
        /// <summary>内力</summary>
        public float internalForce;
        /// <summary>观察</summary>
        public float eyesight;
        /// <summary>听觉</summary>
        public float hearing;
        /// <summary>剑气</summary>
        public float swordBreath;
        /// <summary>身法</summary>
        public float bodilyMovement;
        /// <summary>魅力</summary>
        public float charm;
        /// <summary>命运</summary>
        public float fate;
        /// <summary>指力</summary>
        public float fingerForce;
        /// <summary>横练</summary>
        public float tough;
        /// <summary>体魄</summary>
        public float physique;
        /// <summary>调息</summary>
        public float breath;
        /// <summary>护穴</summary>
        public float acupoint;
        /// <summary>定力</summary>
        public float concentrate;
        /// <summary>抗毒</summary>
        public float antitoxic;
        /// <summary>外伤</summary>
        public float debuffTrauma = 0;
        /// <summary>内伤</summary>
        public float debuffInternalInjury = 0;
        /// <summary>眩晕</summary>
        public float debuffVertigo = 0;
        /// <summary>穴道封闭</summary>
        public float debuffAcupointHit = 0;
        /// <summary>惊惧</summary>
        public float debuffHorror = 0;
        /// <summary>中毒</summary>
        public float debuffToxic = 0;

        public bool IsCopyRaw { set; get; }

        public override IScriptableItem Copy()
        {
            IScriptableItem config = base.Copy();
            KnightBattleConfig target = config as KnightBattleConfig;

            if(IsCopyRaw)
            {
                JSONObject battleBaseSource = mRawJSON["battle_base"];
                target.InitBatteBaseConfig(ref battleBaseSource);

                JSONObject battleBuffSource = mRawJSON["battle_buff"];
                target.InitBatteBaseBuff(ref battleBuffSource);
                
            }
            else
            {
                target.potential = potential;
                target.hp = hp;
                target.mp = mp;
                target.selfHealing = selfHealing;
                target.qi = qi;
                target.internalForce = internalForce;
                target.eyesight = eyesight;
                target.hearing = hearing;
                target.swordBreath = swordBreath;
                target.bodilyMovement = bodilyMovement;
                target.charm = charm;
                target.fate = fate;
                target.fingerForce = fingerForce;
                target.tough = tough;
                target.physique = physique;
                target.breath = breath;
                target.acupoint = acupoint;
                target.concentrate = concentrate;
                target.antitoxic = antitoxic;
                target.debuffTrauma = debuffTrauma;
                target.debuffInternalInjury = debuffInternalInjury;
                target.debuffVertigo = debuffVertigo;
                target.debuffAcupointHit = debuffAcupointHit;
                target.debuffHorror = debuffHorror;
                target.debuffToxic = debuffToxic;
            }

            return config;
        }

        protected override IScriptableItem GetNewConfig()
        {
            return CreateInstance<KnightBattleConfig>();
        }

        public void InitBatteBaseBuff(ref JSONObject source)
        {

            JSONObject battleBuffSource = source["battle_buff"];

            SetRaw(ref battleBuffSource);

            float value = 0f;
            battleBuffSource.GetField(ref value, "tough");
            tough = value / 1000;
            battleBuffSource.GetField(ref value, "physique");
            physique = value / 1000;
            battleBuffSource.GetField(ref value, "breath");
            breath = value / 1000;
            battleBuffSource.GetField(ref value, "acupoint");
            acupoint = value / 1000;
            battleBuffSource.GetField(ref value, "concentrate");
            concentrate = value / 1000;
            battleBuffSource.GetField(ref value, "antitoxic");
            antitoxic = value / 1000;
        }

        public void InitBatteBaseConfig(ref JSONObject source)
        {
            JSONObject battleBaseSource = source["battle_base"];

            SetRaw(ref battleBaseSource);

            float value = 0;
            battleBaseSource.GetField(ref value, "potential");
            potential = value / 1000;
            battleBaseSource.GetField(ref value, "hp");
            hp = value / 1000;
            battleBaseSource.GetField(ref value, "mp");
            mp = value / 1000;
            battleBaseSource.GetField(ref value, "self_healing");
            selfHealing = value / 1000;
            battleBaseSource.GetField(ref value, "qi");
            qi = value / 1000;
            battleBaseSource.GetField(ref value, "eyesight");
            eyesight = value / 1000;
            battleBaseSource.GetField(ref value, "hearing");
            hearing = value / 1000;
            battleBaseSource.GetField(ref value, "sword_breath");
            swordBreath = value / 1000;
            battleBaseSource.GetField(ref value, "bodily_movement");
            bodilyMovement = value / 1000;
            battleBaseSource.GetField(ref value, "charm");
            charm = value / 1000;
            battleBaseSource.GetField(ref value, "fate");
            fate = value / 1000;
            battleBaseSource.GetField(ref value, "finger_force");
            fingerForce = value / 1000;
        }
    }

}