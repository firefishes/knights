using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.StateMachines.States;
using UnityEngine;

namespace FF.Game
{
    public class MainRoleWalkState : AnimatorState
    {

        private RoleMover mRoleMover;

        public MainRoleWalkState(int name) : base(name)
        {
            mRoleMover = new RoleMover();
            mRoleMover.IsMainRole = true;
        }

        public override void UpdateState(float dTime)
        {
            base.UpdateState(dTime);

            mRoleMover.UpdateLog();

            if (mRoleMover.IsStanding)
            {
                ChangeToState(FruitMainRoleStateName.STATE_IDLE);
            }
            else
            {
                Vector3 moveMent = mRoleMover.Movement;
                IOCManager.Emit("MainRoleWalk", moveMent, "GetV3Notice");
                if (mRoleMover.IsRun)
                {
                    ChangeToState(FruitMainRoleStateName.STATE_RUN);
                }
            }
        }
    }
}