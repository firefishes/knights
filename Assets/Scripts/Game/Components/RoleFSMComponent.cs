using ShipDock.Framework.Finess.ECS.Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.AppointerIOC.IOC;
using System;
using ShipDock.Framework.Finess.ECS.Containers;

namespace FF.Game
{
    public class RoleFSMComponent : MonoBehaviour
    {

        [SerializeField]
        private string m_SearchName;
        [SerializeField]
        private RoleComponent m_RoleComponent;
        [SerializeField]
        private RoleAgentComponent m_RoleAgentComponent;

        private void Awake()
        {
            IOCManager.AddContainersReady(OnContainersReady);
        }

        private void OnContainersReady()
        {
            if(m_RoleAgentComponent.isMainRole)
            {
                IStateMachine FSM = new FruitsMainRoleFSM(m_RoleComponent, m_RoleAgentComponent);
                FSMComponent comp = new FSMComponent(FSM, m_SearchName, true);
                FinessECS.CreateEntitas("EntitasEmpty", comp);
            }
        }
    }

}