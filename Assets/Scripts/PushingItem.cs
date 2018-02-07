using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushingItem : MonoBehaviour
{

    public UnityEvent pushEvent;

    void OnMouseDown()
    {
        pushEvent.Invoke();
    }
}
