using ShipDock.Framework.Applications.RPG;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.Applications.RPG.Components;

namespace FF.Game
{

    public class FruitRoleStateName
    {

        public const int STATE_IDLE = 0;
        public const int STATE_WALK = 1;
        public const int STATE_RUN = 2;
        public const int STATE_NOR_ATK = 3;
    }

    public class FruitsRoleFSM : RoleStateMachine, IPoliciableFSM
    {

        private IState[] mStateInfos;
        private RoleComponent mRole;
        private RoleAgentComponent mRoleAgent;
        private RolePolicyer mRolePolicyer;
        private string mPolicyerSearchName;

        public FruitsRoleFSM(string policyerSearchName, RoleComponent role, RoleAgentComponent roleAgent) : base(ref role.roleAnimator, Consts.FSM_FRUIT_MAIN_ROLE, role.transform)
        {
            mRole = role;
            mRoleAgent = roleAgent;
            mPolicyerSearchName = policyerSearchName;
        }

        public override int DefaultState
        {
            get
            {
                return FruitRoleStateName.STATE_IDLE;
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
                        new MainRoleIdleState(FruitRoleStateName.STATE_IDLE),
                        new MainRoleRunState(FruitRoleStateName.STATE_RUN),
                        new MainRoleWalkState(FruitRoleStateName.STATE_WALK),
                        new MainRoleNormalAtkState(FruitRoleStateName.STATE_NOR_ATK),
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
                    mRolePolicyer = new RolePolicyer(this, mPolicyerSearchName);
                    mRolePolicyer.IsMainRole = mRoleAgent.isMainRole;
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