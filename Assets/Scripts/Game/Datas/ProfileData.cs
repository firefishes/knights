using ShipDock.Framework.Cores.Observer.Datas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Knights.Game
{
    public class ProfileData : Proxy
    {

        private PlayerModel mPlayerModel;

        public ProfileData() : base(Consts.PROXY_PROFILE)
        {
        }

        public void InitProfileData(ref KnightDataComponent component)
        {
            mPlayerModel = new PlayerModel();
            mPlayerModel.SetPlayerKnightConfig(ref component);
        }

        public PlayerModel PlayerModel
        {
            get
            {
                return mPlayerModel;
            }
        }

    }

}
