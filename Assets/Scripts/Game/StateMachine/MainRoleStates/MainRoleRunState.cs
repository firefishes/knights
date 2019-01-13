using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.StateMachines.States;
using UnityEngine;

namespace FF.Game
{
    public class MainRoleRunState : AnimatorState
    {

        private RolePolicyer mRolePolicyer;
        private RoleAgentComponent mRoleAgent;

        public MainRoleRunState(int name) : base(name)
        {
        }

        public override void UpdateState(float dTime)
        {
            base.UpdateState(dTime);

            if (mRolePolicyer == null)
            {
                mRolePolicyer = GetFSM<FruitsRoleFSM>().RolePolicyer;
            }

            Vector3 moveMent = mRolePolicyer.Movement;

            if (mRoleAgent == null)
            {
                mRoleAgent = GetFSM<IPoliciableFSM>().RoleAgentComp;
            }
            mRoleAgent.currentSpeed = mRoleAgent.speedRun;
            mRoleAgent.faceToMovement = moveMent;
            
            mAnimator.SetFloat("Forward", 1, 0.1f, Time.deltaTime);
            if (!mRolePolicyer.IsRun)
            {
                ChangeToState(FruitRoleStateName.STATE_IDLE);
            }
        }
    }

}