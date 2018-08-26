using ShipDock.Framework.Cores.Commands;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using ShipDock.Framework.Interfaces;

namespace Knights.Game
{
    public class BattleBackgroundCommand : Command
    {

        public override void InitCommand(IController controller)
        {
            base.InitCommand(controller);
        }

        public override void Execute(ICommandParam param)
        {
            base.Execute(param);


        }

        public override int Name
        {
            get
            {
                return Consts.COMMAND_BATTLE_BACKGROUND;
            }
        }
    }

}