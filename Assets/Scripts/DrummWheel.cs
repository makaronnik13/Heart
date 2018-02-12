using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrummWheel : ConditionChecker {

    public Transform targetTransform;
    private AudioSource source;
    public float needRotation;

    public float rotSpeed = 1;
    public float rot = 0;

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

        float rotY = Input.GetAxis("Mouse X") * rotSpeed * 1000 * Mathf.Deg2Rad;

        if (rotY == 0)
        {
            source.pitch = 0;
        }
        else
        {
            source.pitch = 1;
        }


        targetTransform.Rotate(Vector3.up, rotY, Space.Self);
            rot -= rotY;

        if (rot<0)
        {
            rot = 360 + rot;
        }
        if (rot>360)
        {
            rot = rot - 360;
        }

            Check(Mathf.Abs(rot-needRotation)<=10);
    }

    private void OnMouseUp()
    {
        source.pitch = 0;
    }
}
