using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableMB : ItemMB
{
    private Consumable ItemMBParam;

    void Start()
    {
        ItemMBParam = GameManager.InstanseGameManager.GameConsumables[iItemNumInList];
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
