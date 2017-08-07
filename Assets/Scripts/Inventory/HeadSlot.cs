using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HeadSlot : Slot
{
    [SerializeField]
    private Transform spawnTransform;
    #region IDropHandler
    public override void OnDrop(PointerEventData eventData)
    {
        ItemDragHandle DragItem = eventData.pointerDrag.GetComponent<ItemDragHandle>();
        if (!DragItem.CurrientSlot.IsSlotEmpty() && DragItem.CurrientSlot.ItemInSlot.eSlotType == Items.eItemSlotType.Head)
        {
            GameManager.InstanseGameManager.BackPackInstance.SwapCells(DragItem.CurrientSlot, this);
            ClearSlotPrefab();
            SpawnWear(this.ItemInSlot.ItemPrefab, spawnTransform);
        }
    }
    #endregion

    private void SpawnWear(GameObject spawnPrefab, Transform parentTransform)
    {
        GameObject WearInstance = Instantiate(spawnPrefab, parentTransform.position, parentTransform.rotation);
        WearInstance.transform.parent = parentTransform;
    }

    public override void ClearSlotPrefab()
    {
        if (spawnTransform.childCount > 0)
        {
            Destroy(spawnTransform.GetChild(0).gameObject);
        }
    }
}
