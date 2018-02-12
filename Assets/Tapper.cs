﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tapper : MonoBehaviour {

    private GameObject draggingGo;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                if (Physics.Raycast(ray, out hit))
                {
                    hit.transform.gameObject.SendMessage("OnMouseDown");
                    draggingGo = hit.transform.gameObject;
                }
            }
        }

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Ended || Input.GetTouch(i).phase == TouchPhase.Canceled)
            {
                draggingGo.SendMessage("OnMouseUp");
                draggingGo = null;
            }
        }

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Moved)
            {
                if (draggingGo)
                {
                    draggingGo.SendMessage("OnMouseDrag");
                }
            }
        }
    }
}
