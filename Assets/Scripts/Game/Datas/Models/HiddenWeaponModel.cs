using UnityEngine;

namespace Knights.Game
{
    public class HiddenWeaponModel : EquipmentModel
    {
        public HiddenWeaponModel()
        {

        }

        protected override void InitEquipmentModel(ref JSONObject source)
        {
            mEquipmentConfig = ScriptableObject.CreateInstance<HiddenWeaponConfig>() as IEquipmentConfig;

            mEquipmentConfig.InitEquipmentConfig(ref source);
        }

        public HiddenWeaponConfig HiddenWeaponCompose
        {
            get
            {
                return mEquipmentConfig as HiddenWeaponConfig;
            }
        }

        public override int ModelType
        {
            get
            {
                return Consts.MODEL_HIDDEN_WEAPON;
            }
        }
    }

}