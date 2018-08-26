using ShipDock.Framework.Cores.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Knights.Game
{
    public class KnightsController : Controller
    {
        public override void InitController()
        {
            base.InitController();

        }

        public override int Name
        {
            get
            {
                return Consts.CONTROLLER_KNIGHTS;

            }
        }
    }

}
