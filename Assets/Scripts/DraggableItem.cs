using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentAfterDrag;
    public Image image;
    public TextMeshProUGUI text;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("begindrag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
        text.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("enddrag");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
        text.raycastTarget = true;
    }

    
}
