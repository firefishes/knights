using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipDock.Framework.StateMachines.States;
using ShipDock.Framework.Interfaces;

namespace FF.Game
{
    public class MainRoleIdleState : AnimatorState
    {
        public MainRoleIdleState(int name) : base(name)
        {
            mAnimationName = "Grounded";
        }

        public override void InitState(IStateParam param = null)
        {
            base.InitState(param);

            PlayAnimation();
        }

        public override void UpdateState(float dTime)
        {
            base.UpdateState(dTime);

            if (Movement.magnitude > 0)
            {
                ChangeToState(FruitMainRoleStateName.STATE_WALK);
            }
        }

        public Vector3 Movement
        {
            get
            {
                return new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            }
        }
    }

}