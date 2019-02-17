using ShipDock.Framework.StateMachines.States;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.Tools;
using System;
using ShipDock.Framework.Applications.RPG.Containers;

namespace FF.Game
{
    public class MainRoleNormalAtkState : AnimatorState
    {
        Vector3 raw;
        private int mPrivStateName;
        private RolePolicyer mRolePolicyer;

        public MainRoleNormalAtkState(int name) : base(name)
        {
        }

        public override void InitState(IStateParam param = null)
        {
            base.InitState(param);

            if (mRolePolicyer == null)
            {
                mRolePolicyer = GetFSM<FruitsRoleFSM>().RolePolicyer;
            }
            mPrivStateName = GetFSM<FruitsRoleFSM>().Previous.StateName;
            if(mPrivStateName == StateName)
            {
                mPrivStateName = FruitRoleStateName.STATE_IDLE;
            }
            mAnimator.SetBool("Crouch", true);
            FramesTimer timer = new FramesTimer(0.2f);
            timer.Start(OnAtkEnd);
        }

        private void OnAtkEnd()
        {
            RoleInputer.Instance.IsNomalAttack = false;
            mAnimator.SetBool("Crouch", false);
            ChangeToState(mPrivStateName);
        }
    }

}