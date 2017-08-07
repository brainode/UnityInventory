using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[Serializable]
public class Items : ScriptableObject
{
    public enum eItemRarity
    {
        Common = 1,
        Uncommon = 2,
        Rare = 3,
        Epiq = 4,
        Legendary = 5
    }
    public enum eItemSlotType
    {
        None = 1,
        Head = 2,
        Arm = 3,
        Body = 4,
        Weapon = 5
    }
}
