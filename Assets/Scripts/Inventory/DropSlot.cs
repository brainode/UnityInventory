using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : Slot
{
    private Vector3 spawnPosition;

    [SerializeField]
    private const int FORWARDDROPVECTORMULTIPLIER = 3;
    #region IDropHandler
    public override void OnDrop(PointerEventData eventData)
    {
        ItemDragHandle DragItem = eventData.pointerDrag.GetComponent<ItemDragHandle>();

        
        //Get position in forward of hero
        spawnPosition.x = GameManager.InstanseGameManager.PlayerHero.transform.position.x;
        spawnPosition.z = GameManager.InstanseGameManager.PlayerHero.transform.position.z;
        spawnPosition.y = DragItem.CurrientSlot.ItemInSlot.ItemPrefab.transform.position.y;

        for (int instIter = 0; instIter < DragItem.CurrientSlot.ItemCount; instIter++)
        {
            Instantiate(DragItem.CurrientSlot.ItemInSlot.ItemPrefab, spawnPosition + Vector3.forward * FORWARDDROPVECTORMULTIPLIER, DragItem.CurrientSlot.ItemInSlot.ItemPrefab.transform.rotation);
        }
        if (DragItem.CurrientSlot.GetType().ToString() != "SlotBackPack")
        {
            DragItem.CurrientSlot.ClearSlotPrefab();
        }
        DragItem.CurrientSlot.ClearSlot();
    }
    #endregion
}
