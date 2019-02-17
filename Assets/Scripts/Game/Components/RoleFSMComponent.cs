using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.Finess.ECS.Components;
using ShipDock.Framework.Interfaces;
using UnityEngine;

namespace FF.Game
{
    public class RoleFSMComponent : MonoBehaviour
    {

        [SerializeField]
        private string m_SearchName;
        [SerializeField]
        private string m_PolicyerSearchName;
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
            IStateMachine FSM = new FruitsRoleFSM(m_PolicyerSearchName, m_RoleComponent, m_RoleAgentComponent);
            FSMComponent comp = new FSMComponent(FSM, m_SearchName, true);
            FinessECS.UpdateEntitas("EntitasEmpty", null, comp);
        }
    }

}