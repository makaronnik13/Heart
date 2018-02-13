
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxHandle : ConditionChecker
{

    private float baseAngle = 0.0f;
    private float lastAng;
    public Transform aimTransform;
    public AudioSource source;

    private float speed;
    public float val;

    private void Awake()
    {
        if (!aimTransform)
        {
            aimTransform = transform;
        }
    }

    void OnMouseDown()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(aimTransform.position);
        pos = Input.mousePosition - pos;
        baseAngle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
        baseAngle -= Mathf.Atan2(aimTransform.right.y, aimTransform.right.x) * Mathf.Rad2Deg;
        lastAng = -(Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle);
    }

    private void OnMouseUp()
    {
        DebugText.Instance.Log("mouse up");
        if (val < 1)
        {
            source.pitch = 0;
            val = 0;
        }
    }

    void OnMouseDrag()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(aimTransform.position);
        pos = Input.mousePosition - pos;


        float ang = -(Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle);

        if (lastAng - ang > 0)
        {
            aimTransform.Rotate(Vector3.forward * (lastAng - ang), Space.Self);
            speed += (lastAng - ang) * 0.0003f;
            val += 0.003f;
            source.pitch = 1;
        }
        else
        {
            if (val < 1)
            {
                source.pitch = 0;
                val = Mathf.Lerp(val, 0, Time.deltaTime * 2);
            }
        }

        DebugText.Instance.Log(val+"");

        Check(val>=1);

        lastAng = ang;
        
    }
}