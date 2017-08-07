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

    protected Sprite nullItemIcon;

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
            iconItem.sprite = value.ItemIcon;
        }
    }


    #region MonoBehaviour
    void Awake()
    {
        nullItemIcon = Resources.Load("IconNullItem",typeof(Sprite)) as Sprite;
        itemInSlot = null;
    }
    #endregion
    #region IDropHandler
    public virtual void OnDrop(PointerEventData eventData) { }
    #endregion

    public virtual void ClearSlotPrefab() { }

    public bool IsSlotEmpty()
    {
        return ItemCount > 0 ? false : true;
    }

    public void SwapSlot(Slot toSwap)
    {
        //TODO.Add case when items stackable and ident.
        if (toSwap.itemInSlot != null)
        {
            Item itemToSwap = toSwap.itemInSlot;
            int itemToSwapCount = toSwap.itemCount;
            toSwap.ItemInSlot = itemInSlot;
            toSwap.ItemCount = itemCount;
            this.ItemInSlot = itemToSwap;
            this.ItemCount = itemToSwapCount;
        }
        else
        {
            toSwap.ItemInSlot = itemInSlot;
            toSwap.ItemCount = itemCount;
            this.ClearSlot();
        }
        
    }

    public void ClearSlot()
    {
        itemInSlot = null;
        iconItem.sprite = nullItemIcon;
        itemCount = 0;
    }

}
