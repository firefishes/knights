using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.Finess.ECS.Containers;

namespace FF.Game
{
    public class GameContainer : ContainerIOC
    {

        public GameContainer()
        {
            IOCManager.Add(new RoleContainer());
            IOCManager.Add(new SystemContainer());
            IOCManager.Add(new ComponentsContainer());
            IOCManager.Add(new RolePolicyerContainer());
        }

        public override void Start()
        {
            base.Start();
        }

        public override void Finish()
        {
            base.Finish();
        }
    }

}