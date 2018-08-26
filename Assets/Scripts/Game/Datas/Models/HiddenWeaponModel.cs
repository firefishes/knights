namespace Knights.Game
{
    public class HiddenWeaponModel : EquipmentModel
    {
        private HiddenWeaponConfig mHiddenWeaponConfig;

        public HiddenWeaponModel()
        {

        }

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);
        }

        public HiddenWeaponConfig HiddenWeaponCompose
        {
            get
            {
                return mHiddenWeaponConfig;
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