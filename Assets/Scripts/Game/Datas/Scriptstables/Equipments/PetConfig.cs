using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 豢养数据
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/PetConfig")]
    public class PetConfig : EquipmentConfig
    {
        /// <summary>药</summary>
        public float medicine;
        /// <summary>毒</summary>
        public float toxin;
        /// <summary>喂养</summary>
        public int feedID;

        public override void InitEquipmentConfig(ref JSONObject source)
        {
            base.InitEquipmentConfig(ref source);

            JSONObject petRaw = source["pet"];
            InitPetConfig(ref petRaw);
        }

        private void InitPetConfig(ref JSONObject source)
        {
            float value = 0;
            int valueInt = 0;
            DataUtils.SetConfigValue(ref source, ref value, ref medicine, "medicine");
            DataUtils.SetConfigValue(ref source, ref value, ref toxin, "toxin");
            DataUtils.SetConfigValue(ref source, ref valueInt, ref feedID, "feed_id");
        }
    }

}