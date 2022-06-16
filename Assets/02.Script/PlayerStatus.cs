using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStatus
{
    static float _pSpeed = 10;
    static float _pHp = 100;
    static float _pExp = 0;
    static float _pAttack = 10;
    static float _pLevel = 1;
    public static float _PSpeed
    {
        get
        {
            return _pSpeed;
        }
        set
        {
            _pSpeed = value;
        }
    }
    public static float PHp
    {
        get
        {
            return _pHp;
        }
        set
        {
            _pHp = value;
        }
    }

    public static float PExp
    {
        get
        {
            return _pExp;
        }
        set
        {
            _pExp = value;
        }
    }
    public static float PAttack
    {
        get
        {
            return _pAttack;
        }
        set
        {
            _pAttack = value;
        }
    }
    public static float PLevel
    {
        get
        {
            return _pLevel;
        }
        set
        {
            _pLevel = value;
        }
    }
}
