using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.StateMachines.States;
using UnityEngine;

namespace FF.Game
{
    public class MainRoleWalkState : AnimatorState
    {

        private RolePolicyer mRolePolicyer;

        public MainRoleWalkState(int name) : base(name)
        {
            //mAnimator.SetFloat()
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
                else
                {
                    //float z = 0;
                    //if(mRolePolicyer.Inputer.IsRight())
                    //{
                    //    z = moveMent.x;
                    //}
                    //else if(mRolePolicyer.Inputer.IsLeft())
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
                    mAnimator.SetFloat("Forward", 0.5f, 0.1f, Time.deltaTime);
                }
            }
        }
    }
}