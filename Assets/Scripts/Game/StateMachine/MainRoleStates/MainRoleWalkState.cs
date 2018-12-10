using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.StateMachines.States;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FF.Game
{
    public class MainRoleWalkState : AnimatorState
    {
        public MainRoleWalkState(int name) : base(name)
        {
        }

        public override void UpdateState(float dTime)
        {
            base.UpdateState(dTime);

            if(Movement.magnitude <= 0.1f)
            {
                ChangeToState(FruitMainRoleStateName.STATE_IDLE);
            }
            else
            {
                IOCManager.Emit("MainRoleWalk", Movement, "GetV3Notice");
            }
        }

        public Vector3 Movement
        {
            get
            {
                return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            }
        }
    }

}