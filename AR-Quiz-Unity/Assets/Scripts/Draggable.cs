using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

    public Sprite startSprite;
    public Sprite planet;

    public TheTrigger jawaban;

    public bool isDragged = false;
    Vector3 mouseStartDragPos;
    Vector3 spriteStartDragPos;
    private SpriteRenderer rend;
    private BoxCollider2D colliderObj;


    Vector3 startPos;

    private void Start()
    {
        startPos = this.transform.position;
        rend = GetComponent<SpriteRenderer>();
        colliderObj = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    public void OnMouseDown()
    {

        isDragged = true;
        mouseStartDragPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteStartDragPos = transform.localPosition;
        rend.sprite = planet;
        colliderObj.size = new Vector2(2f, 2f);

    }
    public void OnMouseDrag()
    {
        if (isDragged)
        {
            transform.localPosition = spriteStartDragPos + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseStartDragPos);
          //  Debug.Log(transform.position.y);
        }
    }

    void cancelDrag()
    {
        rend.sprite = startSprite;
        transform.position = startPos;
        colliderObj.size = new Vector2(4f, 3f);
    }
    public void OnMouseUp()
    {
        isDragged = false;
        if (transform.position.y < 0.3f || transform.position.y > 3.1f)
        {
            cancelDrag();
            return;
        }
        if (jawaban.benar == true)
        {
            jawaban.triggerBenar();
        }
        else
        {
            cancelDrag();
            jawaban.triggerSalah();
        }
        //cek event
    }
}
