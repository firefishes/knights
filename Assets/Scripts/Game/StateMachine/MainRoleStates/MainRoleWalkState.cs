using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.StateMachines.States;
using UnityEngine;

namespace FF.Game
{
    public class MainRoleWalkState : AnimatorState
    {

        private RolePolicyer mRolePolicyer;

        public MainRoleWalkState(int name) : base(name)
        {
        }

        public override void UpdateState(float dTime)
        {
            base.UpdateState(dTime);

            if (mRolePolicyer == null)
            {
                mRolePolicyer = GetFSM<FruitsMainRoleFSM>().RolePolicyer;
            }

            mRolePolicyer.UpdateLog();

            if (mRolePolicyer.IsStanding)
            {
                ChangeToState(FruitMainRoleStateName.STATE_IDLE);
            }
            else
            {
                Vector3 moveMent = mRolePolicyer.Movement;
                IOCManager.Emit("MainRoleWalk", moveMent, "GetV3Notice");
                if (mRolePolicyer.IsRun)
                {
                    ChangeToState(FruitMainRoleStateName.STATE_RUN);
                }
            }
        }
    }
}