using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePointTrigger : MonoBehaviour
{
    public FocusPoint point;

    private void Awake()
    {
        point.OnExit+=Exit;    
    }

    private void Exit()
    {
        GetComponent<Collider>().enabled = true;
    }

    void OnMouseDown()
    {
        point.Activate();
        GetComponent<Collider>().enabled = false;
    }
}
