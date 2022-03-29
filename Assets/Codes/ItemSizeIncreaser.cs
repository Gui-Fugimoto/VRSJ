using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSizeIncreaser : MonoBehaviour //IPointerDownHandler, IPointerUpHandler
{
    public Transform Item;
    private bool isDragging;
    private float currentScale, scaleRate = 2, temp;
    public float minScale, maxScale;
    public bool Dragou=false;

    // Start is called before the first frame update
    void Start()
    {
        currentScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {

        
        if (isDragging)
        {
            if (Input.touchCount == 2)
            {
                transform.localScale = new Vector3(x: currentScale, y: currentScale, z: currentScale);

                float distance = Vector3.Distance(a: Input.GetTouch(index: 0).position, b: Input.GetTouch(index: 1).position);

                if (temp > distance)
                {
                    if (currentScale < minScale)
                    {
                        return;

                    }

                    currentScale -= (Time.deltaTime) * scaleRate;

                }
                else if (temp < distance)
                {
                    if (currentScale >= maxScale)
                    {
                        return;
                    }
                    currentScale += (Time.deltaTime) * scaleRate;
                }
                temp = distance;
            }
        }
    }

    void OnMouseDown()
    {
        if(Input.touchCount == 2)
        {
            isDragging = true;
            Debug.Log("Pinch");
        }
        
    }

    void OnMouseUp()
    {
        isDragging = false;
        Debug.Log("Exit");
    }

    
}

  
