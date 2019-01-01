using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.StateMachines.States;
using UnityEngine;

namespace FF.Game
{
    public class MainRoleRunState : AnimatorState
    {

        private RolePolicyer mRolePolicyer;

        public MainRoleRunState(int name) : base(name)
        {
        }

        public override void UpdateState(float dTime)
        {
            base.UpdateState(dTime);

            if (mRolePolicyer == null)
            {
                mRolePolicyer = GetFSM<FruitsMainRoleFSM>().RolePolicyer;
            }

            if (mRolePolicyer.IsRun)
            {
                Vector3 moveMent = mRolePolicyer.Movement;
                IOCManager.Emit("MainRoleRun", moveMent, "GetV3Notice");
            }
            else
            {
                ChangeToState(FruitMainRoleStateName.STATE_IDLE);
            }
        }
    }

}