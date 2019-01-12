using ShipDock.Framework.AppointerIOC.IOC;
using UnityEngine;
using ShipDock.Framework.Finess.ECS;
using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.Finess.ECS.Containers;
using System.Collections.Generic;

namespace FF.Game
{
    public class RoleContainer : ContainerIOC, IEntitasSystem
    {
        private RoleComponent mRole;
        private RoleAgentComponent mRoleAgent;
        private List<IEntitasComponent> mRoles;
        private List<IEntitasComponent> mRoleAgents;

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

        private void RoleMove(ref RoleAgentComponent agentComp, ref RoleComponent roleComp, Vector3 v)
        {
            roleComp.characterController.SimpleMove(v);

            if (!agentComp.isNeedCheckRoleFaceTo)
            {
                agentComp.isNeedCheckRoleFaceTo = true;
            }
        }

        private void UpdateRoleFacing(ref RoleAgentComponent roleAgent, ref Transform roleTF)
        {
            if (!roleAgent.isNeedCheckRoleFaceTo)
            {
                return;
            }
            
            roleTF.LookAt(roleTF.position + roleAgent.faceToMovement);

            if (Mathf.Abs(roleTF.rotation.y) <= 1)
            {
                roleAgent.currentSpeed = 0;
                roleAgent.isNeedCheckRoleFaceTo = false;
            }
        }

        public T GetEntitasComponent<T>(int key) where T : IEntitasComponent
        {
            return FinessECS.GetComponet<T>(key);
        }

        public void OnExecute(ref IEntitasSystem system, int time)
        {
            if(IsActive)
            {
                if(IsChanged)
                {
                    mRoles = FinessECS.GetComponents("RoleComponent");
                }
                if (mRoles != null)
                {
                    int max = mRoles.Count;
                    for (int i = 0; i < max; i++)
                    {
                        mRole = mRoles[i] as RoleComponent;
                        mRoleAgent = mRole.roleAgent;
                        if(mRoleAgent.currentSpeed != 0)
                        {
                            RoleMove(ref mRoleAgent, ref mRole, mRoleAgent.faceToMovement * mRoleAgent.currentSpeed);
                        }
                        UpdateRoleFacing(ref mRoleAgent, ref mRole.cachedTF);
                    }
                }
            }
        }

        public string EntitasSystemName
        {
            get
            {
                return "Roles";
            }
        }

        public bool IsActive { get; set; }

        public bool IsChanged { get; set; }
    }

}