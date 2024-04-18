using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectPaper : MonoBehaviour
{
    // Start is called before the first frame update
    private bool dragging = false;
    private Vector3 offset;
    public Collider2D lockSlot;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
        if (GetComponent<BoxCollider2D>().IsTouching(lockSlot))
        {
            this.transform.position = lockSlot.transform.position;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
