using ShipDock.Framework.AppointerIOC.IOC;
using ShipDock.Framework.Finess.ECS;
using ShipDock.Framework.Finess.ECS.Containers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace FF.Game
{
    public class AttackCheckContainer : ContainerIOC, IEntitasSystem
    {

        public override void Start()
        {
            base.Start();
        }

        public override void Finish()
        {
            base.Finish();

            FinessECS.AddSystem(this);
        }

        public void OnExecute(ref IEntitasSystem system, int time)
        {
        }

        public bool IsActive { get; set; }

        public bool IsChanged { get; set; }

        public string EntitasSystemName
        {
            get
            {
                return "AttackCheckSystem";
            }
        }
    }

}