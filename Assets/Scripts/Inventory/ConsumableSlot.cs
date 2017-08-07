using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConsumableSlot : Slot
{

    #region IDropHandler
    public override void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop on cons");
        ItemDragHandle DragItem = eventData.pointerDrag.GetComponent<ItemDragHandle>();
        if (!DragItem.CurrientSlot.IsSlotEmpty() && DragItem.CurrientSlot.ItemInSlot.eSlotType == Items.eItemSlotType.Consumable)
        {
            GameManager.InstanseGameManager.BackPackInstance.SwapCells(DragItem.CurrientSlot, this);
        }
    }
    #endregion
}
