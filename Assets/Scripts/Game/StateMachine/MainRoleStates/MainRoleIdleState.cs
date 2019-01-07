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
        private RolePolicyer mRolePolicyer;

        public MainRoleIdleState(int name) : base(name)
        {
            mAnimationName = "Grounded";
        }

        public override void InitState(IStateParam param = null)
        {
            base.InitState(param);

            if(mRolePolicyer == null)
            {
                mRolePolicyer = GetFSM<FruitsMainRoleFSM>().RolePolicyer;
            }

            PlayAnimation();

            mRolePolicyer.Inputer.ResetRunKeyCheck();
        }

        public override void UpdateState(float dTime)
        {
            base.UpdateState(dTime);
            
            if (!mRolePolicyer.IsStanding)
            {
                if(mRolePolicyer.Inputer.canCheckRun && mRolePolicyer.IsRun)
                {
                    ChangeToState(FruitMainRoleStateName.STATE_RUN);
                }
                else if(!mRolePolicyer.Inputer.canCheckRun)
                {
                    ChangeToState(FruitMainRoleStateName.STATE_WALK);
                }
            }
            else
            {
                mAnimator.SetFloat("Forward", 0);// 0.1f, Time.deltaTime);
            }
        }
    }

}