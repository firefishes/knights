using ShipDock.Framework.Cores.Commands;
using ShipDock.Framework.Interfaces;

namespace Knights.Game
{
    public class KnightsCommand : Command
    {

        public override void InitCommand(IController controller)
        {
            base.InitCommand(controller);
        }

        public override void Execute(ICommandParam param)
        {
            base.Execute(param);
        }

        public override int Name
        {
            get
            {
                return Consts.COMMAND_KNIGHTS;
            }
        }
    }
}