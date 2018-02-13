using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObject : ConditionChecker {

    private bool en = true;
    private AudioSource source;
    public Transform targetTransform;
    public float rotSpeed = 1;
    private float rot = 0;
    public float minRot = 0;
    public float maxRot = 360*4;
    private void Awake()
    {
        if (!targetTransform)
        {
            targetTransform = transform;
        }
        source = GetComponent<AudioSource>();
    }

    void OnMouseDrag()
    {
        if (!en)
        {
            return;
        }

        float rotY = Input.GetAxis("Mouse Y") * rotSpeed*1000 * Mathf.Deg2Rad;

        if (rotY == 0)
        {
            source.pitch = 0;
        }
        else
        {
            source.pitch = 1;
        }

        if ((rotY>0 && rot>minRot) || (rotY < 0 && rot<maxRot))
        {
            targetTransform.Rotate(Vector3.up, -rotY, Space.Self);
            rot -= rotY;

            if (rot >= maxRot)
            {
                en = false;
            }
            Check(rot >= maxRot);
        }
    }

    private void OnMouseUp()
    {
        source.pitch = 0;
    }
}
