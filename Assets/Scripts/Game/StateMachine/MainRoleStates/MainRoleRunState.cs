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

            Vector3 moveMent = mRolePolicyer.Movement;
            IOCManager.Emit("MainRoleRun", moveMent, "GetV3Notice");
            mAnimator.SetFloat("Forward", 1, 0.1f, Time.deltaTime);
            if (!mRolePolicyer.IsRun)
            {
                ChangeToState(FruitMainRoleStateName.STATE_IDLE);
            }
            //float z = 0;
            //if (mRolePolicyer.Inputer.IsRight())
            //{
            //    z = moveMent.x;
            //}
            //else if (mRolePolicyer.Inputer.IsLeft())
            //{
            //    z = -moveMent.x;
            //}
            //else if (mRolePolicyer.Inputer.IsUp())
            //{
            //    z = moveMent.z;
            //}
            //else if (mRolePolicyer.Inputer.IsDown())
            //{
            //    z = -moveMent.z;
            //}
        }
    }

}