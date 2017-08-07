using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackPack : MonoBehaviour//, IDropHandler
{
    private SlotBackPack[] backPackSlots;

    void Awake()
    {
        backPackSlots = GetComponentsInChildren<SlotBackPack>();
    }

    public bool PutItemAtInventory(Item ItemToPut)
    {
        for (int slotIter = 0; slotIter < backPackSlots.Length; slotIter++)
        {
            if (backPackSlots[slotIter].CanBePlaced(ItemToPut))
            {
                backPackSlots[slotIter].PutItemAtCell(ItemToPut);
                return true;
            }
        }
        return false;
    }

    public void SwapCells(Slot fromSlot,Slot toSlot)
    {
        //fromSlot.SwapSlot(toSlot);
        if (!toSlot.IsSlotEmpty() && fromSlot.IsTypeAccessible(toSlot.ItemInSlot) || toSlot.IsSlotEmpty())
        {
            fromSlot.SwapSlot(toSlot);
        }
    }
}
