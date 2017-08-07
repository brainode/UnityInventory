using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SlotBackPack : Slot
{
    public bool CanBePlaced(Item ItemToPlace)
    {
        if (ItemCount == 0)
        {
            return true;
        }
        else
        {
            if (ItemInSlot == ItemToPlace && ItemToPlace.bIsStackable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    #region IDropHandler
    public override void OnDrop(PointerEventData eventData)
    {
        ItemDragHandle DragItem = eventData.pointerDrag.GetComponent<ItemDragHandle>();
        if (!DragItem.CurrientSlot.IsSlotEmpty())
        {
            if (this.IsSlotEmpty() && DragItem.CurrientSlot.GetType().ToString() != "SlotBackPack")
            {
                DragItem.CurrientSlot.ClearSlotPrefab();
            }
            GameManager.InstanseGameManager.BackPackInstance.SwapCells(DragItem.CurrientSlot, this);
        }
    }
    #endregion
}
