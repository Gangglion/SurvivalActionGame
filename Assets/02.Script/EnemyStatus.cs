using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 작성자 : 한승협
public static class EnemyStatus
{
    // 적 스텟 : S,M,L 순
    static float[] _eHp = new float[] { 30, 60, 90 };
    // 적 초기 속도
    static float _eSpeed = 8;
    // 적 공격력
    static float[] _eAttack = new float[] { 10, 20, 30 };
    // 적 제공 경험치
    static float[] _eExp = new float[] { 10, 20, 30 };

    public static float[] EHp
    {
        get
        {
            return _eHp;
        }
        set
        {
            _eHp = value;
        }
    }
    public static float ESpeed
    {
        get
        {
            return _eSpeed;
        }
        set
        {
            _eSpeed = value;
        }
    }
    public static float[] EAttack
    {
        get
        {
            return _eAttack;
        }
        set
        {
            _eAttack = value;
        }
    }
    public static float[] EExp
    {
        get
        {
            return _eExp;
        }
        set
        {
            _eExp = value;
        }
    }
}
