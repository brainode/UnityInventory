using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Consumables", menuName = "Items/ConsumablesList")]
public class Consumables : Items
{
    [SerializeField]
    private List<Consumable> listConsumables;

    public Consumable this[int i]
    {
        get { return listConsumables[i]; }
    }
}
