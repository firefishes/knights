using ShipDock.Framework.AppointerIOC.IOC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.ObjectPool;
using ShipDock.Framework.Cores.Notices;
using ShipDock.Framework.RPG.Components;

namespace FF.Game
{
    public class MainRoleContainer : ContainerIOC
    {

        private MainRoleComponent mMainRoleComponent;

        public override void Start()
        {
            base.Start();

            Register<CommonValueNotice<MainRoleComponent>, IValueHolder<MainRoleComponent>>("GetMainCharacterControllerNotice", Pooling<CommonValueNotice<MainRoleComponent>>.Instance);
        }

        public override void Finish()
        {
            base.Finish();

            SetAppoint<IValueHolder<MainRoleComponent>>(this, SetMainCharacterController, "GetMainCharacterControllerNotice");
            SetAppoint<IValueHolder<Vector3>>(this, MainRoleWalk, "GetV3Notice");
        }

        private void MainRoleWalk<I>(ref I target)
        {
            Vector3 v = (target as IValueHolder<Vector3>).GetValue();
            //mMainRoleComponent.characterController.Move(v);
            mMainRoleComponent.characterController.SimpleMove(v * 10);
        }

        private void SetMainCharacterController<I>(ref I target)
        {
            mMainRoleComponent = (target as IValueHolder<MainRoleComponent>).GetValue();
            FruitsMainRoleFSM fsm = new FruitsMainRoleFSM();
            fsm.Run(null, FruitMainRoleStateName.STATE_IDLE);
        }
    }

}