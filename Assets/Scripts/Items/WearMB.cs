using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearMB : ItemMB
{

    private Wear ItemMBParam;

    void Start()
    {
        ItemMBParam = GameManager.InstanseGameManager.GameWears[iItemNumInList];
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
