using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ArmSlot : Slot
{
    [SerializeField]
    private Transform spawnTransform;

    #region IDropHandler
    public override void OnDrop(PointerEventData eventData)
    {
        ItemDragHandle DragItem = eventData.pointerDrag.GetComponent<ItemDragHandle>();
        if (!DragItem.CurrientSlot.IsSlotEmpty() && DragItem.CurrientSlot.ItemInSlot.eSlotType == Items.eItemSlotType.Weapon)
        {
            GameManager.InstanseGameManager.BackPackInstance.SwapCells(DragItem.CurrientSlot,this);
            ClearSlotPrefab();
            SpawnWeapon(this.ItemInSlot.ItemPrefab, spawnTransform);
        }
    }
    #endregion

    private void SpawnWeapon(GameObject spawnPrefab,Transform parentTransform)
    {
        GameObject WeaponInstance = Instantiate(spawnPrefab, parentTransform.position, parentTransform.rotation);
        WeaponInstance.transform.parent = parentTransform;
    }

    public override void ClearSlotPrefab()
    {
        if (spawnTransform.childCount > 0)
        {
            Destroy(spawnTransform.GetChild(0).gameObject);
        }
    }
}
