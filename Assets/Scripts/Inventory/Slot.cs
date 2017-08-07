using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{
    [SerializeField]
    protected int slotId;

    [SerializeField]
    protected Items.eItemSlotType slotTypeRequied;

    protected Image iconItem;

    protected Text itemCountText;

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
        itemCountText = GetComponentInChildren<Text>();
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

    public bool IsTypeAccessible(Item itemToPut)
    {
        if (itemToPut.eSlotType == slotTypeRequied)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SwapSlot(Slot toSwap)
    {
        //TODO.Add case when items stackable and ident.
        if (toSwap.itemInSlot != null)
        {
            if (toSwap.itemInSlot == this.ItemInSlot)
            {
                toSwap.ItemCount += itemCount;
                this.ClearSlot();
            }
            else
            {
                Item itemToSwap = toSwap.itemInSlot;
                int itemToSwapCount = toSwap.itemCount;
                toSwap.ItemInSlot = itemInSlot;
                toSwap.ItemCount = itemCount;
                this.ItemInSlot = itemToSwap;
                this.ItemCount = itemToSwapCount;
            }
        }
        else
        {
            toSwap.ItemInSlot = itemInSlot;
            toSwap.ItemCount = itemCount;
            this.ClearSlot();
        }
        toSwap.UpdateCountLabel();
        this.UpdateCountLabel();
    }

    public void ClearSlot()
    {
        itemInSlot = null;
        iconItem.sprite = nullItemIcon;
        itemCount = 0;
        UpdateCountLabel();
    }

    public void PutItemAtCell(Item itemToPut)
    {
        this.ItemInSlot = itemToPut;
        this.ItemCount += 1;
        UpdateCountLabel();
    }

    private void UpdateCountLabel()
    {
        try
        {
            if (itemCount > 0 && itemInSlot.bIsStackable)
            {
                itemCountText.text = itemCount.ToString();
            }
            else
            {
                itemCountText.text = "";
            }
        }
        catch (NullReferenceException nExp){}
    }
}
