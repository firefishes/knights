using ShipDock.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Knights.Game
{
    public class Consts
    {
        /// <summary>修炼类武学</summary>
        public const int TYPE_MAR_ARTS_PRACTICE = 0;
        /// <summary>战斗类武学</summary>
        public const int TYPE_MAR_ARTS_BATTLE = 1;
        /// <summary>特殊类武学</summary>
        public const int TYPE_MAR_ARTS_SPECIAL = 2;

        /// <summary>残本</summary>
        public const int CARRIER_REMNANT = 0;
        /// <summary>器具</summary>
        public const int CARRIER_APPLIANCES = 1;
        /// <summary>秘笈</summary>
        public const int CARRIER_ESOTERICA = 2;
        /// <summary>金属</summary>
        public const int CARRIER_METAL = 3;
        /// <summary>洞刻</summary>
        public const int CARRIER_CAVE_CARVING = 4;

        /// <summary>无需兵刃</summary>
        public const int TYPE_WEAPON_NONE = 0;
        /// <summary>剑</summary>
        public const int TYPE_WEAPON_SWORD = 1;
        /// <summary>刀</summary>
        public const int TYPE_WEAPON_BLADE = 2;
        /// <summary>长兵</summary>
        public const int TYPE_WEAPON_TALL = 3;
        /// <summary>短兵</summary>
        public const int TYPE_WEAPON_SHORT = 4;
        /// <summary>重兵</summary>
        public const int TYPE_WEAPON_HEAVY = 5;
        /// <summary>软兵</summary>
        public const int TYPE_WEAPON_SOFT = 6;
        /// <summary>奇形</summary>
        public const int TYPE_WEAPON_STRAGE = 7;
        /// <summary>专属</summary>
        public const int TYPE_WEAPON_EXCLUSIVE = 8;

        public const int TYPE_STUFF_METAL = 0;
        public const int TYPE_STUFF_NONMETAL = 1;
        public const int TYPE_STUFF_ALIEN = 2;

        /// <summary>头戴</summary>
        public const int TYPE_EQUIP_HEAD = 0;
        /// <summary>披挂</summary>
        public const int TYPE_EQUIP_DRAPING = 1;
        /// <summary>衣着</summary>
        public const int TYPE_EQUIP_COAT = 2;
        /// <summary>佩戴</summary>
        public const int TYPE_EQUIP_WEAR = 3;
        /// <summary>兵刃</summary>
        public const int TYPE_EQUIP_WEAPON = 4;
        /// <summary>足履</summary>
        public const int TYPE_EQUIP_SHOES = 5;
        /// <summary>暗器</summary>
        public const int TYPE_EQUIP_HIDDEN_WEAPON = 6;
        /// <summary>坐骑</summary>
        public const int TYPE_EQUIP_RIDING = 7;
        /// <summary>行囊</summary>
        public const int TYPE_EQUIP_BAG = 8;
        /// <summary>豢养</summary>
        public const int TYPE_EQUIP_PET = 9;
        /// <summary>药物</summary>
        public const int TYPE_DRUGGERY = 10;

        public const int MODEL_BASE = -1;
        public const int MODEL_KNIGHT = 0;
        public const int MODEL_PLAYER = 1;
        public const int MODEL_EQUIPMENT = 2;
        public const int MODEL_WEAPON = 3;
        public const int MODEL_HIDDEN_WEAPON = 4;
        public const int MODEL_PET = 5;
        public const int MODEL_BLUEPRINT = 6;
        public const int MODEL_ITEM = 7;
        public const int MODEL_MINE = 8;
        public const int MODEL_MARTIAL_ART = 8;

        public const int CONTROLLER_KNIGHTS = 2001;
        public const int CONTROLLER_BATTLE = 2002;

        public const int COMMAND_KNIGHTS = 3001;
        public const int COMMAND_GAME_DATA = 3002;
        public const int COMMAND_BATTLE_BACKGROUND = 3003;

        public const int PROXY_PROFILE = 8001;
    }

}