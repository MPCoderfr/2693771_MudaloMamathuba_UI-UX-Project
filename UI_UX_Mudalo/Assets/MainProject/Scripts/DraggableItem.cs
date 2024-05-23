using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Item itemScriptable;

    [Header("UI")]
    public Image image;
    
    [HideInInspector] public Transform parentAfterDrag;

    
    public void InitialiseItem(Item newItem)
    {
        itemScriptable = newItem;
        image.sprite = newItem.Sprite;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();

        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Vector3 mousePos = Input.mousePosition;
        //transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = mousePos;

        //Chnage the position of an object this script is attached to.
        transform.position = Input.mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }

}
