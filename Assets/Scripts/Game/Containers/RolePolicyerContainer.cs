using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framewrok.Managers;
using System.Collections.Generic;
using ShipDock.Framework.Containers;
using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.Finess.ECS;

namespace FF.Game
{
    public class RolePolicyerContainer : ContainerIOC
    {
        private RolePolicyer mRolePolicyer;
        private List<IEntitasComponent> mList;

        public override void Start()
        {
            base.Start();

        }

        public override void Finish()
        {
            base.Finish();

            GameUpdaterManager.Instance.Add(UpdatePolicyer);
        }

        private void UpdatePolicyer(int obj)
        {
            mList = ComponentAppointer.GetComponents("RolePoilcyerComponent");
            if(mList == null)
            {
                return;
            }
            int max = mList.Count;
            for (int i = 0; i < max; i++)
            {
                mRolePolicyer = mList[i] as RolePolicyer;
                if (mRolePolicyer != null)
                {
                    if(mRolePolicyer.IsMainRole)
                    {
                        if(mRolePolicyer.Inputer.IsNomalAttack)
                        {
                            mRolePolicyer.PoliciableFSM.ChangeState(FruitMainRoleStateName.STATE_NOR_ATK);
                        }
                    }
                }
            }
        }
    }

}