using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SellItem : MonoBehaviour, IDropHandler
{

    public WalletScript moneyDisplay;
    
    private int cost = 15;
    
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem sellItem = dropped.GetComponent<DraggableItem>();
            sellItem.parentAfterDrag = transform;

            
            moneyDisplay.moneyCounter += cost;
            moneyDisplay.ConvertToText();
            Destroy(dropped);
            
            
            //SellThis();
        }

        
        
    }


    public void SellThis()
    {
       
    }

}
