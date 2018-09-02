using UnityEngine;

namespace Knights.Game
{
    public class EquipmentModel : GameModel
    {

        protected IEquipmentConfig mEquipmentConfig;

        public override void Dispose()
        {

        }

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            mEquipmentConfig = ScriptableObject.CreateInstance<EquipmentConfig>() as IEquipmentConfig;

            mEquipmentConfig.InitEquipmentConfig(ref source);
        }

        public override int ID
        {
            get
            {
                return (mEquipmentConfig != null) ? mEquipmentConfig.id : base.ID;
            }
        }

        public override int ModelType
        {
            get
            {
                return Consts.MODEL_EQUIPMENT;
            }
        }

        public IEquipmentConfig EquipmentCompose
        {
            get
            {
                return mEquipmentConfig;
            }
        }

        public override string Name
        {
            get
            {
                return (mEquipmentConfig != null) ? mEquipmentConfig.Name : base.Name;
            }
        }

        public override int NameID
        {
            get
            {
                return (mEquipmentConfig != null) ? mEquipmentConfig.NameID : base.NameID;
            }
        }
    }

}