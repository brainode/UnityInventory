using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMB : ItemMB
{
    private Weapon ItemMBParam;

    void Start()
    {
        ItemMBParam = GameManager.InstanseGameManager.GameWeapons[iItemNumInList];
    }
    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.tag == "Player")
        {
            if (GameManager.InstanseGameManager.BackPackInstance.PutItemAtInventory(ItemMBParam))
            {
                Destroy(gameObject);
            }
        }
    }
}
