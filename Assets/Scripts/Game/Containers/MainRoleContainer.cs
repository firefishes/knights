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
        MainRoleComponent mMainRoleComponent;
        RoleAgentComponent mMainRoleAgentComponent;
        Transform mMainRoleTF;
        Transform mRoleAgentTF;
        private int mMainRoleComponentKey;
        private int mMainRoleAgentComponentKey;

        public override void Start()
        {
            base.Start();

            Register<ParamNotice<int>, IValueHolder<int>>("GetMainCharacterControllerNotice", Pooling<ParamNotice<int>>.Instance);
            Register<ParamNotice<int>, IValueHolder<int>>("GetMainRoleAgentNotice", Pooling<ParamNotice<int>>.Instance);
        }

        public override void Finish()
        {
            base.Finish();

            SetAppoint<IValueHolder<int>>(this, SetMainCharacterController, "GetMainCharacterControllerNotice");
            SetAppoint<IValueHolder<int>>(this, SetMainRoleAgentComponent, "GetMainRoleAgentNotice");
            SetAppoint<IValueHolder<Vector3>>(this, MainRoleWalk);
        }

        private void SetMainRoleAgentComponent<I>(ref I target)
        {
            mMainRoleAgentComponentKey = (target as IValueHolder<int>).GetValue();
        }

        private void MainRoleWalk<I>(ref I target)
        {
            Vector3 v = (target as IValueHolder<Vector3>).GetValue();
            mMainRoleAgentComponent.faceToMovement = v;
            mMainRoleComponent.characterController.SimpleMove(v * 15);

            if (!mMainRoleAgentComponent.isNeedCheckRoleFaceTo)
            {
                mMainRoleAgentComponent.isNeedCheckRoleFaceTo = true;
            }
        }

        private void OnMainRoleFaceingMovement(int time)
        {
            if (!mMainRoleAgentComponent.isNeedCheckRoleFaceTo)
            {
                return;
            }
            mMainRoleTF.LookAt(mRoleAgentTF.position + mMainRoleAgentComponent.faceToMovement);
            if (Mathf.Abs(mMainRoleTF.rotation.y - mRoleAgentTF.rotation.y) <= 1)
            {
                mMainRoleAgentComponent.isNeedCheckRoleFaceTo = false;
            }
        }

        private void SetMainCharacterController<I>(ref I target)
        {
            mMainRoleComponentKey = (target as IValueHolder<int>).GetValue();
            mMainRoleComponent = GetEntitasComponent<MainRoleComponent>(mMainRoleComponentKey);

            mMainRoleAgentComponent = GetEntitasComponent<RoleAgentComponent>(mMainRoleAgentComponentKey);
            mMainRoleComponent.characterController = mMainRoleAgentComponent.characterController;

            if (mMainRoleTF == null)
            {
                mMainRoleTF = mMainRoleComponent.cachedTF;
            }
            if (mRoleAgentTF == null)
            {
                mRoleAgentTF = mMainRoleAgentComponent.cachedTF;
            }

            FruitsMainRoleFSM fsm = new FruitsMainRoleFSM();
            fsm.Run(null, FruitMainRoleStateName.STATE_IDLE);

            GameUpdaterManager.Instance.Add(OnMainRoleFaceingMovement);
        }

        public T GetEntitasComponent<T>(int key) where T : IEntitasComponent
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