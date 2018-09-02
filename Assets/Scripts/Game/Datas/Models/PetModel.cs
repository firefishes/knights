using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Knights.Game
{
    public class PetModel : EquipmentModel
    {

        public PetModel()
        {

        }

        protected override void InitEquipmentModel(ref JSONObject source)
        {
            base.InitEquipmentModel(ref source);

            mEquipmentConfig = ScriptableObject.CreateInstance<PetConfig>();
            mEquipmentConfig.InitEquipmentConfig(ref source);
        }

        public PetConfig PetConfigCompose
        {
            get
            {
                return mEquipmentConfig as PetConfig;
            }
        }

        public override int ModelType
        {
            get
            {
                return Consts.MODEL_PET;
            }
        }
    }

}