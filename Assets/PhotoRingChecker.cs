using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoRingChecker : ConditionChecker
{
    public float rotSpeed = 1;
    private Vector2 lastMousePosition;


    private void OnMouseDown()
    {
        lastMousePosition = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 currentMousePosition = Input.mousePosition;

        float rotation = Vector2.SignedAngle(lastMousePosition, currentMousePosition);

        //Quaternion initialRotation = transform.localRotation;
        transform.Rotate(Vector3.forward, -rotation*rotSpeed*1000, Space.Self);

       // transform.localRotation = Quaternion.Lerp(initialRotation, transform.localRotation, Time.deltaTime);

        lastMousePosition = currentMousePosition;
    }
}