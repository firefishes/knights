using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Knights.Game
{
    public class WeaponModel : EquipmentModel
    {

        private WeaponConfig mWeaponConfig;

        public WeaponModel()
        {

        }

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);


        }

        public WeaponConfig WeaponCompose
        {
            get
            {
                return mWeaponConfig;
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