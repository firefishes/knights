using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.StateMachines.States;
using UnityEngine;

namespace FF.Game
{
    public class MainRoleRunState : AnimatorState
    {

        private RoleMover mRoleMover;

        public MainRoleRunState(int name) : base(name)
        {
            mRoleMover = new RoleMover();
            mRoleMover.IsMainRole = true;
        }

        public override void UpdateState(float dTime)
        {
            base.UpdateState(dTime);

            if(mRoleMover.IsRun)
            {
                Vector3 moveMent = mRoleMover.Movement;
                IOCManager.Emit("MainRoleRun", moveMent, "GetV3Notice");
            }
            else
            {
                ChangeToState(FruitMainRoleStateName.STATE_IDLE);
            }
        }
    }

}