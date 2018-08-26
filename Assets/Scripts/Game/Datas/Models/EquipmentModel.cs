namespace Knights.Game
{
    public class EquipmentModel : GameModel
    {

        private EquipmentConfig mEquipmentConfig;

        public override void Dispose()
        {

        }

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);

            mName = mEquipmentConfig.name;
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

        public EquipmentConfig EquipmentCompose
        {
            get
            {
                return mEquipmentConfig;
            }
        }
    }

}