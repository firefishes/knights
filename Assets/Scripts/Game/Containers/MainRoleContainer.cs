using ShipDock.Framework.AppointerIOC.IOC;
using UnityEngine;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.ObjectPool;
using ShipDock.Framework.Cores.Notices;
using ShipDock.Framework.RPG.Components;
using ShipDock.Framewrok.Managers;
using ShipDock.Framework.Finess.ECS;
using ShipDock.Framework.Containers;

namespace FF.Game
{
    public class MainRoleContainer : ContainerIOC, IEntitasSystem
    {
        //private MainRoleComponent mMainRoleComponent;
        //private RoleAgentComponent mMainRoleAgentComponent;
        private EntitasComponentKey mMainRoleAgentComponentKey;

        public override void Start()
        {
            base.Start();

            Register<ParamNotice<EntitasComponentKey>, IValueHolder<EntitasComponentKey>>("GetMainCharacterControllerNotice", Pooling<ParamNotice<EntitasComponentKey>>.Instance);
            Register<ParamNotice<EntitasComponentKey>, IValueHolder<EntitasComponentKey>>("GetMainRoleAgentNotice", Pooling<ParamNotice<EntitasComponentKey>>.Instance);
        }

        public override void Finish()
        {
            base.Finish();

            SetAppoint<IValueHolder<EntitasComponentKey>>(this, SetMainCharacterController, "GetMainCharacterControllerNotice");
            SetAppoint<IValueHolder<EntitasComponentKey>>(this, SetMainRoleAgentComponent, "GetMainRoleAgentNotice");
            SetAppoint<IValueHolder<Vector3>>(this, MainRoleWalk);
        }

        private void SetMainRoleAgentComponent<I>(ref I target)
        {
            //mMainRoleAgentComponent = (target as IValueHolder<RoleAgentComponent>).GetValue();
            mMainRoleAgentComponentKey = (target as IValueHolder<EntitasComponentKey>).GetValue();
        }

        private void MainRoleWalk<I>(ref I target)
        {
            Vector3 v = (target as IValueHolder<Vector3>).GetValue();
            //mMainRoleAgentComponent.faceToMovement = v;
            //mMainRoleComponent.characterController.SimpleMove(v * 15);

            //if(!mMainRoleAgentComponent.isNeedCheckRoleFaceTo)
            //{
            //    mMainRoleAgentComponent.isNeedCheckRoleFaceTo = true;
            //    GameUpdaterManager.Instance.Add(OnMainRoleFaceingMovement);
            //}
        }

        private void OnMainRoleFaceingMovement(int time)
        {
            RoleAgentComponent agentComponent = GetEntitasComponent<RoleAgentComponent>(ref mMainRoleAgentComponentKey);
            if (!agentComponent.isNeedCheckRoleFaceTo)
            {
                GameUpdaterManager.Instance.Remove(OnMainRoleFaceingMovement);
                return;
            }

            //mMainRoleComponent.cachedTF.LookAt(agentComponent.cachedTF.position + agentComponent.faceToMovement);
            //if(Mathf.Abs(mMainRoleComponent.cachedTF.rotation.y - agentComponent.cachedTF.rotation.y) <= 1)
            //{
            //    agentComponent.isNeedCheckRoleFaceTo = false;
            //}
        }

        private void SetMainCharacterController<I>(ref I target)
        {
            var t = target;
            //EntitasComponentKey key = (target as IValueHolder<EntitasComponentKey>).GetValue();
            //MainRoleComponent component = GetEntitasComponent<MainRoleComponent>(ref key);
            //mMainRoleComponent = (target as IValueHolder<MainRoleComponent>).GetValue();

            //RoleAgentComponent agentComponent = GetEntitasComponent<RoleAgentComponent>(ref mMainRoleAgentComponentKey);
            //component.characterController = agentComponent.characterController;

            //FruitsMainRoleFSM fsm = new FruitsMainRoleFSM();
            //fsm.Run(null, FruitMainRoleStateName.STATE_IDLE);
        }

        public T GetEntitasComponent<T>(ref EntitasComponentKey key) where T : IEntitasComponent
        {
            return ComponentAppointer.GetComponet<T>(key);
        }

        public string EntitasSystemName
        {
            get
            {
                return "MainRoleContainer";
            }
        }
    }

}