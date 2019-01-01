using ShipDock.Framework.StateMachines.States;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipDock.Framework.Interfaces;
using ShipDock.Framework.Applications.RPG.Components;
using ShipDock.Framework.Tools;
using System;

namespace FF.Game
{
    public class MainRoleNormalAtkState : AnimatorState
    {
        Vector3 raw;
        private int mPrivStateName;
        private RolePolicyer mRolePolicyer;

        public MainRoleNormalAtkState(int name) : base(name)
        {
        }

        public override void InitState(IStateParam param = null)
        {
            base.InitState(param);

            if (mRolePolicyer == null)
            {
                mRolePolicyer = GetFSM<FruitsMainRoleFSM>().RolePolicyer;
            }
            mPrivStateName = GetFSM<FruitsMainRoleFSM>().Previous.StateName;
            if(mPrivStateName == StateName)
            {
                mPrivStateName = FruitMainRoleStateName.STATE_IDLE;
            }
            raw = GetFSM<FruitsMainRoleFSM>().RoleComp.cachedTF.localScale;
            GetFSM<FruitsMainRoleFSM>().RoleComp.cachedTF.localScale = new Vector3(raw.x, raw.y, raw.z * 3);
            FramesTimer timer = new FramesTimer(0.2f);
            timer.Start(OnAtkEnd);
        }

        private void OnAtkEnd()
        {
            GetFSM<FruitsMainRoleFSM>().RoleComp.cachedTF.localScale = raw;
            ChangeToState(mPrivStateName);
        }
    }

}