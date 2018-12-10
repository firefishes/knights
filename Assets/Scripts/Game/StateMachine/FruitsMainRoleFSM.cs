using ShipDock.Framework.Applications.RPG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipDock.Framework.Interfaces;

namespace FF.Game
{
    public class FruitMainRoleStateName
    {

        public const int STATE_IDLE = 0;
        public const int STATE_WALK = 1;
        public const int STATE_RUN = 2;
        public const int STATE_NOR_ATK = 3;
    }

    public class FruitsMainRoleFSM : RoleStateMachine
    {

        public FruitsMainRoleFSM() : base(Consts.FSM_FRUIT_MAIN_ROLE)
        {
        }

        public override int DefaultState
        {
            get
            {
                return FruitMainRoleStateName.STATE_IDLE;
            }
        }

        public override IState[] StateInfos
        {
            get
            {
                return new IState[]
                {
                    new MainRoleIdleState(FruitMainRoleStateName.STATE_IDLE),
                    new MainRoleRunState(FruitMainRoleStateName.STATE_RUN),
                    new MainRoleWalkState(FruitMainRoleStateName.STATE_WALK),
                    new MainRoleNormalAtkState(FruitMainRoleStateName.STATE_NOR_ATK),
                };
            }
        }
    }

}