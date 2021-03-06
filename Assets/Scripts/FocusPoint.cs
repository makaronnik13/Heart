﻿using UnityEngine;
using System;

public class FocusPoint: MonoBehaviour
{
    public Action OnExit = ()=> { };
    public Vector3 localOffset;
    public float fow;
    public bool enableRotation;
    public FocusPoint previousPoint;

    public float maxRotation = 90;
    public float minRotation = -90;
    public bool clampRotation = false;

    private void Start()
    {
        foreach (Collider c in GetComponentsInChildren<Collider>())
        {
            if (c.GetComponent<ChangePointTrigger>() == null)
            {
               // c.enabled = false;
            }
        }
    }

    public void Deactivate(float time)
    {
        Invoke("Deactivate", time);
    }

    public void Deactivate()
    {
        foreach (Collider c in GetComponentsInChildren<Collider>())
        {
            if (c.GetComponent<ChangePointTrigger>() == null)
            {
                //c.enabled = false;
            }
        }

        if (previousPoint)
        {
            CameraController.Instance.SetPoint(previousPoint);
        }

        OnExit.Invoke();
    }

    public void Activate(float time)
    {
        Invoke("Activate", time);
    }

    public void Activate()
    {
        foreach (Collider c in GetComponentsInChildren<Collider>())
        {
            //c.enabled = true;
        }
        CameraController.Instance.SetPoint(this);
    }
}