namespace Knights.Game
{
    public class DruggeryBuffConfig : ScriptableItem
    {
        public int targetType;
        public KnightBattleConfig buffBattle;
        public KnightBattleConfig debuffBattle;
        public KnightMeridianConfig buffMeridian;
        public KnightMeridianConfig debuffMeridian;

        protected override IScriptableItem GetNewConfig()
        {
            return CreateInstance<DruggeryBuffConfig>();
        }

        public override IScriptableItem Copy()
        {
            IScriptableItem config = base.Copy() as IScriptableItem;

            DruggeryBuffConfig target = config as DruggeryBuffConfig;

            target.buffBattle = buffBattle.Copy() as KnightBattleConfig;
            target.debuffBattle = buffBattle.Copy() as KnightBattleConfig;
            target.buffMeridian = buffMeridian.Copy() as KnightMeridianConfig;
            target.debuffMeridian = debuffMeridian.Copy() as KnightMeridianConfig;
            return config;
        }
    }

}