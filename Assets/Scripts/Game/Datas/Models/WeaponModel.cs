using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Knights.Game
{
    public class WeaponModel : EquipmentModel
    {

        public WeaponModel()
        {

        }

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            mEquipmentConfig = ScriptableObject.CreateInstance<WeaponConfig>();
            mEquipmentConfig.InitEquipmentConfig(ref source);
        }

        public WeaponConfig WeaponCompose
        {
            get
            {
                return mEquipmentConfig as WeaponConfig;
            }
        }

        public override int ModelType
        {
            get
            {
                return Consts.MODEL_WEAPON;
            }
        }
    }

}