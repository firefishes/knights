using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 图纸数据
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/BlueprintConfig")]
    public class BlueprintConfig : ItemConfig
    {
        /// <summary>矿</summary>
        public float mine;
        /// <summary>丝</summary>
        public float silk;
        /// <summary>药</summary>
        public float medicine;
        /// <summary>毒</summary>
        public float toxin;

        public override IScriptableItem Copy()
        {
            IScriptableItem config = base.Copy();
            BlueprintConfig target = config as BlueprintConfig;
            target.mine = mine;
            target.silk = silk;
            target.medicine = medicine;
            target.toxin = toxin;
            return config;
        }

        protected override IScriptableItem GetNewConfig()
        {
            return CreateInstance<BlueprintConfig>();
        }
    }

}