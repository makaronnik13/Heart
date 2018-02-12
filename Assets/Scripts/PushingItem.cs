using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushingItem : MonoBehaviour
{

    public UnityEvent pushEvent;

    void OnMouseDown()
    {
        if (GetComponent<AudioSource>())
        {
            GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
        }
        pushEvent.Invoke();
    }
}
