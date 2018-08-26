using ShipDock.Framework.Cores.Commands;
using UnityEngine;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.Managers;

namespace Knights.Game
{
    public class GameDataCommand : Command
    {

        [SerializeField]
        private KnightDataComponent m_PlayerDataComp;

        private ProfileData mProfileData;

        public override void InitCommand(IController controller)
        {
            base.InitCommand(controller);

            mProfileData = new ProfileData();

            DataManager.Instance.AddDataProxy(mProfileData);

            mProfileData.InitProfileData(ref m_PlayerDataComp);
            mProfileData.PlayerModel.BaseCompose.firstName = "上官灭";
        }

        public override void Execute(ICommandParam param)
        {
            base.Execute(param);
        }

        public override int Name
        {
            get
            {
                return Consts.COMMAND_GAME_DATA;
            }
        }
    }

}