using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingItem : ConditionChecker {

    public float minY = 0;
    public float maxY = 1;
    public bool inverce = false;
    private bool stack = false;

    public float needVal;

    public Transform targetTransform;
    public float movSpeed = 1;
    
    public float y = 0;

    private void Awake()
    {
        if (!targetTransform)
        {
            targetTransform = transform;
        }    
    }

    void OnMouseDrag()
    {
        if (stack)
        {
            return;
        }
        float rotY = Input.GetAxis("Mouse Y") * movSpeed;

        if (inverce)
        {
            rotY = -rotY;
        }

        if ((rotY>0 && y<maxY) || (rotY<0 && y>minY))
        {
            y += rotY;
            targetTransform.Translate(-Vector3.up * rotY, Space.Self);
            Check(Mathf.Abs(y - needVal) < 0.005f);
            if (Mathf.Abs(y - needVal) < 0.005f)
            {
                stack = true;
            }
        }
    }

}
