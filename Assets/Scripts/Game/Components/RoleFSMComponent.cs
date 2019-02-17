using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.Finess.ECS.Components;
using ShipDock.Framework.Interfaces;
using UnityEngine;

namespace FF.Game
{
    public class RoleFSMComponent : MonoBehaviour
    {

        private static int roleCompInstanceCount = 0;

        [SerializeField]
        private int m_RoleFSMName;
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
            m_RoleFSMName = gameObject.GetInstanceID();
            gameObject.name = "R_".Append(m_RoleFSMName.ToString(), "_", roleCompInstanceCount.ToString());
            roleCompInstanceCount++;

            IOCManager.AddContainersReady(OnContainersReady);
        }

        private void OnContainersReady()
        {
            IStateMachine FSM = new FruitsRoleFSM(m_RoleFSMName, m_PolicyerSearchName, m_RoleComponent, m_RoleAgentComponent);
            FSMComponent comp = new FSMComponent(FSM, m_SearchName, true);
            FinessECS.UpdateEntitas(gameObject.name, null, comp);
        }
    }

}