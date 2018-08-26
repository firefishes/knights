using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Knights.Game
{
    public class PetModel : EquipmentModel
    {
        private PetConfig mPetConfig;

        public PetModel()
        {

        }

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);
        }

        public PetConfig PetConfigCompose
        {
            get
            {
                return mPetConfig;
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