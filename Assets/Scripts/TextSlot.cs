using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextSlot : MonoBehaviour, IDropHandler
{

    public Vector2 cellSize;
    public GridLayoutGroup gridLayout;
    public float width;
    public float height;
    public Rect rect;
    public Image image;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggleItem = dropped.GetComponent<DraggableItem>();
            draggleItem.parentAfterDrag = transform;
        }
    }

    public void Start()
    {
        image = GetComponent<Image>();
        GetImagesize();
        gridLayout = GetComponent<GridLayoutGroup>();
        gridLayout.cellSize = new Vector2(width, height);
    }

    public void GetImagesize()
    {
        rect = image.rectTransform.rect;
        width = rect.width;
        height = rect.height;
    }
}
