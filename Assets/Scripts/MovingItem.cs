using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingItem : ConditionChecker {

    public float minY = 0;
    public float maxY = 1;
    public Transform targetTransform;
    public float movSpeed = 1;
    
    private float y = 0;

    private void Awake()
    {
        if (!targetTransform)
        {
            targetTransform = transform;
        }    
    }

    void OnMouseDrag()
    {
        
        float rotY = Input.GetAxis("Mouse Y") * movSpeed;
        if ((rotY>0 && y<maxY) || (rotY<0 && y>minY))
        {
            y += rotY;
            targetTransform.Translate(-Vector3.up * rotY, Space.Self);
            Check(Mathf.Abs(targetTransform.localPosition.y - minY) < maxY / 10);
        }
    }

}
