using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class Item
{
    [Header("Item Parameters")]
    //[Header("Item Name")]
    public string sName;
    //[Header("Item Icon")]
    //public Texture2D t2dIcon;
    public Sprite ItemIcon;
    //[Header("Item Rarity")]
    public Items.eItemRarity eRarity;
    //[Header("Item Slot Type Needed")]
    public Items.eItemSlotType eSlotType;
    //[Header("Item Stackability")]
    public bool bIsStackable;

    public GameObject ItemPrefab;
}
