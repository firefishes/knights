namespace Knights.Game
{
    /// <summary>
    /// 物品数据
    /// </summary>
    public class ItemModel : GameModel
    {

        protected IItemConfig mItemConfig;

        public ItemModel()
        {
        }

        public override void InitModel(ref JSONObject source)
        {
            base.InitModel(ref source);
        }

        public override int ID
        {
            get
            {
                return (mItemConfig != null) ? mItemConfig.GetItemID() : base.ID;
            }
        }

        public IScriptableItem ItemConfigCompose
        {
            get
            {
                return mItemConfig;
            }
        }

        public override int ModelType
        {
            get
            {
                return Consts.MODEL_ITEM;
            }
        }
    }

}