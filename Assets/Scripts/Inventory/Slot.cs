using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{
    [SerializeField]
    protected int slotId;

    protected Image iconItem;

    public Image IconItem
    {
        set { iconItem = value; }
    }

    public int SlotId
    {
        get{ return slotId; }
    }

    protected int itemCount = 0;

    public int ItemCount
    {
        get { return itemCount; }
        set { itemCount = value; }
    }

    protected Item itemInSlot;
    public Item ItemInSlot
    {
        get { return itemInSlot; }
        set
        {
            itemInSlot = value;
            itemCount += 1;
            iconItem.sprite = value.ItemIcon;
        }
    }

    #region IDropHandler
    public virtual void OnDrop(PointerEventData eventData) { }
    #endregion

}
