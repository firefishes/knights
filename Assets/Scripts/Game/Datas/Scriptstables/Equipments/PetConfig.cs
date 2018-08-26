using UnityEngine;

namespace Knights.Game
{
    /// <summary>
    /// 豢养数据
    /// </summary>
    [CreateAssetMenu(menuName = "Knights/Game/Assets/PetConfig")]
    public class PetConfig : EquipmentConfig
    {
        /// <summary>药</summary>
        public float medicine;
        /// <summary>毒</summary>
        public float toxin;
        /// <summary>喂养</summary>
        public int feed;
    }

}