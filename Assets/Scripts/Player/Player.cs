using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

[Serializable]
public struct HeroStats
{
    public int iStrenght;
    public int iDexterity;
    public int iVitality;
    public int iEnergy;
}


public class Player : MonoBehaviour
{
    [SerializeField]
    private HeroStats stats;

    [SerializeField]
    private Transform leftHand;

    [SerializeField]
    private Transform rightHand;

    [SerializeField]
    private Transform head;

    public Transform LeftHand
    {
        get { return leftHand; }
    }

    public Transform RightHand
    {
        get { return rightHand; }
    }

    public Transform Head
    {
        get { return head; }
    }

    public 

    void Start ()
	{
    }

    #region InventoryMethods
   
    #endregion

    void Update () {
	}
    
}
