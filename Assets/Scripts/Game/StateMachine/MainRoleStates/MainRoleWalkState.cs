using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.StateMachines.States;
using UnityEngine;

namespace FF.Game
{
    public class MainRoleWalkState : AnimatorState
    {

        private RolePolicyer mRolePolicyer;
        private RoleAgentComponent mRoleAgent;

        public MainRoleWalkState(int name) : base(name)
        {
        }

        public override void InitState(IStateParam param = null)
        {
            base.InitState(param);
        }

        public override void UpdateState(float dTime)
        {
            base.UpdateState(dTime);

            if (mRolePolicyer == null)
            {
                mRolePolicyer = GetFSM<FruitsRoleFSM>().RolePolicyer;
            }

            mRolePolicyer.UpdateLog();

            if (mRolePolicyer.IsStanding)
            {
                ChangeToState(FruitRoleStateName.STATE_IDLE);
            }
            else
            {
                Vector3 moveMent = mRolePolicyer.Movement;

                if(mRoleAgent == null)
                {
                    mRoleAgent = GetFSM<IPoliciableFSM>().RoleAgentComp;
                }
                mRoleAgent.currentSpeed = mRoleAgent.speedWalk;
                mRoleAgent.faceToMovement = moveMent;
                if (mRolePolicyer.IsRun)
                {
                    ChangeToState(FruitRoleStateName.STATE_RUN);
                }
                else
                {
                    mAnimator.SetFloat("Forward", 0.5f, 0.1f, Time.deltaTime);
                }
            }
        }
    }
}