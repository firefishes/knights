using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipDock.Framework.StateMachines.States;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.Applications.RPG.Components;

namespace FF.Game
{
    public class MainRoleIdleState : AnimatorState
    {
        private RoleMover mRoleMover;

        public MainRoleIdleState(int name) : base(name)
        {
            mAnimationName = "Grounded";
            mRoleMover = new RoleMover();
            mRoleMover.IsMainRole = true;
        }

        public override void InitState(IStateParam param = null)
        {
            base.InitState(param);

            PlayAnimation();

            mRoleMover.Inputer.ResetRunKeyCheck();
        }

        public override void UpdateState(float dTime)
        {
            base.UpdateState(dTime);
            
            if (!mRoleMover.IsStanding)
            {
                if(mRoleMover.Inputer.canCheckRun && mRoleMover.IsRun)
                {
                    ChangeToState(FruitMainRoleStateName.STATE_RUN);
                }
                else if(!mRoleMover.Inputer.canCheckRun)
                {
                    ChangeToState(FruitMainRoleStateName.STATE_WALK);
                }
            }
        }
    }

}