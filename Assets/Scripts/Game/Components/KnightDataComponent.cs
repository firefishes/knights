using Knights.Game;
using UnityEngine;

public class KnightDataComponent : MonoBehaviour
{

    /// <summary>基础数据</summary>
    [SerializeField]
    private KnightBaseConfig m_BaseData = null;
    /// <summary>资产数据</summary>
    [SerializeField]
    private KnightMeansConfig m_MeansData = null;
    /// <summary>造诣数据</summary>
    [SerializeField]
    private KnightAttainmentsConfig m_AttainmentsData = null;
    /// <summary>造诣最大值数据</summary>
    [SerializeField]
    private KnightAttainmentsConfig m_AttainmentsMaxData = null;
    /// <summary>经脉数据</summary>
    [SerializeField]
    private KnightMeridianConfig m_MeridianData = null;
    /// <summary>战斗数据</summary>
    [SerializeField]
    private KnightBattleConfig m_BattleData = null;

    public KnightBaseConfig BaseData
    {
        get
        {
            return m_BaseData;
        }
    }

    public KnightMeansConfig MeansData
    {
        get
        {
            return m_MeansData;
        }
    }

    public KnightAttainmentsConfig AttainmentsData
    {
        get
        {
            return m_AttainmentsData;
        }
    }

    public KnightAttainmentsConfig AttainmentsMaxData
    {
        get
        {
            return m_AttainmentsMaxData;
        }
    }

    public KnightMeridianConfig MeridianData
    {
        get
        {
            return m_MeridianData;
        }
    }

    public KnightBattleConfig BattleData
    {
        get
        {
            return m_BattleData;
        }
    }
}