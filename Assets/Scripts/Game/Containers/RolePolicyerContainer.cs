using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framewrok.Managers;
using System.Collections.Generic;
using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.Finess.ECS;
using ShipDock.Framework.Finess.ECS.Containers;

namespace FF.Game
{
    public class RolePolicyerContainer : ContainerIOC, IEntitasSystem
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

            IsActive = true;
            FinessECS.AddSystem(this);
        }

        public void OnExecute(ref IEntitasSystem system, int time)
        {
            mList = FinessECS.GetComponents("RolePoilcyerComponent");
            if (mList == null)
            {
                return;
            }
            int max = mList.Count;
            for (int i = 0; i < max; i++)
            {
                mRolePolicyer = mList[i] as RolePolicyer;
                if (mRolePolicyer != null)
                {
                    if (mRolePolicyer.IsMainRole)
                    {
                        if (mRolePolicyer.Inputer.IsNomalAttack)
                        {
                            mRolePolicyer.PoliciableFSM.ChangeState(FruitMainRoleStateName.STATE_NOR_ATK);
                        }
                    }
                }
            }
        }

        public bool IsActive { get; set; }

        public bool IsChanged { get; set; }

        public string EntitasSystemName
        {
            get
            {
                return "RolePolicyerSystem";
            }
        }
    }

}