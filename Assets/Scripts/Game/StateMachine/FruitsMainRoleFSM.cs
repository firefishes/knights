using ShipDock.Framework.Applications.RPG;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.Applications.RPG.Components;

namespace FF.Game
{

    public class FruitMainRoleStateName
    {

        public const int STATE_IDLE = 0;
        public const int STATE_WALK = 1;
        public const int STATE_RUN = 2;
        public const int STATE_NOR_ATK = 3;
    }

    public class FruitsMainRoleFSM : RoleStateMachine, IPoliciableFSM
    {

        private IState[] mStateInfos;
        private RoleComponent mRole;
        private RoleAgentComponent mRoleAgent;
        private RolePolicyer mRolePolicyer;

        public FruitsMainRoleFSM(RoleComponent role, RoleAgentComponent roleAgent) : base(ref role.roleAnimator, Consts.FSM_FRUIT_MAIN_ROLE, role.transform)
        {
            mRole = role;
            mRoleAgent = roleAgent;
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
                if (mStateInfos == null)
                {
                    mStateInfos = new IState[]
                    {
                        new MainRoleIdleState(FruitMainRoleStateName.STATE_IDLE),
                        new MainRoleRunState(FruitMainRoleStateName.STATE_RUN),
                        new MainRoleWalkState(FruitMainRoleStateName.STATE_WALK),
                        new MainRoleNormalAtkState(FruitMainRoleStateName.STATE_NOR_ATK),
                    };
                }
                return mStateInfos;
            }
        }

        public RolePolicyer RolePolicyer
        {
            get
            {
                if(mRolePolicyer == null)
                {
                    mRolePolicyer = new RolePolicyer(this);
                    mRolePolicyer.IsMainRole = true;
                }
                return mRolePolicyer;
            }
        }

        public RoleComponent RoleComp
        {
            get
            {
                return mRole;
            }
        }

        public RoleAgentComponent RoleAgentComp
        {
            get
            {
                return mRoleAgent;
            }
        }

    }

}