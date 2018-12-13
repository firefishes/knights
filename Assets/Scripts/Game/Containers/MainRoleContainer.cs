using ShipDock.Framework.AppointerIOC.IOC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.ObjectPool;
using ShipDock.Framework.Cores.Notices;
using ShipDock.Framework.RPG.Components;
using ShipDock.Framewrok.Managers;
using ShipDock.Framework.Tools;

namespace FF.Game
{
    public class MainRoleContainer : ContainerIOC
    {
        private MainRoleComponent mMainRoleComponent;
        private RoleAgentComponent mMainRoleAgentComponent;
        
        public override void Start()
        {
            base.Start();

            Register<CommonValueNotice<MainRoleComponent>, IValueHolder<MainRoleComponent>>("GetMainCharacterControllerNotice", Pooling<CommonValueNotice<MainRoleComponent>>.Instance);
            Register<CommonValueNotice<RoleAgentComponent>, IValueHolder<RoleAgentComponent>>("GetMainRoleAgentNotice", Pooling<CommonValueNotice<RoleAgentComponent>>.Instance);
        }

        public override void Finish()
        {
            base.Finish();

            SetAppoint<IValueHolder<MainRoleComponent>>(this, SetMainCharacterController, "GetMainCharacterControllerNotice");
            SetAppoint<IValueHolder<RoleAgentComponent>>(this, SetMainRoleAgentComponent, "GetMainRoleAgentNotice");
            SetAppoint<IValueHolder<Vector3>>(this, MainRoleWalk, "GetV3Notice");
        }

        private void SetMainRoleAgentComponent<I>(ref I target)
        {
            mMainRoleAgentComponent = (target as IValueHolder<RoleAgentComponent>).GetValue();
        }

        private void MainRoleWalk<I>(ref I target)
        {
            Vector3 v = (target as IValueHolder<Vector3>).GetValue();
            mMainRoleAgentComponent.faceToMovement = v;
            mMainRoleComponent.characterController.SimpleMove(v * 15);

            if(!mMainRoleAgentComponent.isNeedCheckRoleFaceTo)
            {
                mMainRoleAgentComponent.isNeedCheckRoleFaceTo = true;
                GameUpdaterManager.Instance.Add(OnMainRoleFaceingMovement);
            }
        }

        private void OnMainRoleFaceingMovement(int time)
        {
            if(!mMainRoleAgentComponent.isNeedCheckRoleFaceTo)
            {
                GameUpdaterManager.Instance.Remove(OnMainRoleFaceingMovement);
                return;
            }

            mMainRoleComponent.cachedTF.LookAt(mMainRoleAgentComponent.cachedTF.position + mMainRoleAgentComponent.faceToMovement);
            if(Mathf.Abs(mMainRoleComponent.cachedTF.rotation.y - mMainRoleAgentComponent.cachedTF.rotation.y) <= 1)
            {
                mMainRoleAgentComponent.isNeedCheckRoleFaceTo = false;
            }
        }

        private void SetMainCharacterController<I>(ref I target)
        {
            mMainRoleComponent = (target as IValueHolder<MainRoleComponent>).GetValue();
            mMainRoleComponent.characterController = mMainRoleAgentComponent.characterController;

            FruitsMainRoleFSM fsm = new FruitsMainRoleFSM();
            fsm.Run(null, FruitMainRoleStateName.STATE_IDLE);
        }
    }

}