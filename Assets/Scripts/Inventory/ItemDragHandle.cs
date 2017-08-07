using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDragHandle : MonoBehaviour, IDragHandler,IBeginDragHandler, IEndDragHandler//, IDropHandler
{
    private Transform startParentTransform;
    private int slotId;

    #region MonoBehaviour
    void Awake()
    {
        slotId = GetComponentInParent<SlotBackPack>().SlotId;
        GetComponentInParent<SlotBackPack>().IconItem = GetComponent<Image>();
    }
    #endregion

    public int SlotId
    {
        get{ return slotId; }
    }

    #region IBeginDragHandler
    public void OnBeginDrag(PointerEventData eventData)
    {
        startParentTransform = transform.parent;
        transform.SetParent(transform.parent.parent.parent);
        transform.position = eventData.position;
        GetComponent<CanvasGroup>().blocksRaycasts = false;

        Debug.Log("Drag start from:"+SlotId);
    }
    #endregion

    #region IDragHandler
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
    #endregion

    #region IEndDragHandler
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(startParentTransform);
        transform.position = startParentTransform.position;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    #endregion

   
}
