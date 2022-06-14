using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private float pSpeed = 10;
    private float pHp = 100;
    private float pExp = 0;
    private float pAttack = 1;
    private float pLevel = 1;
    public float PSpeed
    {
        get
        {
            return pSpeed;
        }
        set
        {
            pSpeed = value;
        }
    }
    public float PHp
    {
        get
        {
            return pHp;
        }
        set
        {
            pHp = value;
        }
    }

    public float PExp
    {
        get
        {
            return pExp;
        }
        set
        {
            pExp = value;
        }
    }
    public float PAttack
    {
        get
        {
            return pAttack;
        }
        set
        {
            pAttack = value;
        }
    }
    public float PLevel
    {
        get
        {
            return pLevel;
        }
        set
        {
            pLevel = value;
        }
    }
}
