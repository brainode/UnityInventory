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
            if (backPackSlots[slotIter].SlotId!=0 && backPackSlots[slotIter].CanBePlaced(ItemToPut))
            {
                backPackSlots[slotIter].ItemInSlot = ItemToPut;
                backPackSlots[slotIter].ItemCount += 1;
                return true;
            }
        }
        return false;
    }

    public void SwapCells(Slot fromSlot,Slot toSlot)
    {
        fromSlot.SwapSlot(toSlot);
    }
}
