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
    private HeroStats Stats;

    void Start ()
	{
    }

    #region InventoryMethods
   
    #endregion

    void Update () {
	}
    
}
