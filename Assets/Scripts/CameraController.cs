using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : Singleton<CameraController> {

    private float angle = 0;
    public float zoomOut = 1;
    public float deltaAngle = 0;
    private float time = 0;

    public FocusPoint currentPoint;


    public void SetPoint(FocusPoint previousPoint)
    {
        time = 0;
        angle = 0;
        currentPoint = previousPoint;
        deltaAngle = 0;
    }

    private void Start()
    {
        SetPoint(currentPoint);
    }

    // Update is called once per frame
    void Update ()
    {
        time += Time.deltaTime/10;

        transform.localPosition = Vector3.Lerp(transform.localPosition, RotatePointAroundPivot(currentPoint.transform.TransformPoint(currentPoint.localOffset), currentPoint.transform.position, Vector3.up*angle), time/4);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(currentPoint.transform.position - transform.position), time);
        Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, currentPoint.fow, time);

        //mobile input zoom
        if (currentPoint.previousPoint && Input.touchCount ==2 )
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            Vector2 touch1Prev = touch1.position - touch1.deltaPosition;
            Vector2 touch2Prev = touch2.position - touch2.deltaPosition;


            float prevDeltaMagn = (touch1Prev- touch2Prev).magnitude;
            float deltaMagn = (touch1.position - touch2.position).magnitude;
            float deltaMagnDif = prevDeltaMagn - deltaMagn;

            if (deltaMagnDif>zoomOut)
            {
                currentPoint.Deactivate();
            }
        }

        //pc input zoom
        if (currentPoint.previousPoint)
        {
            if (-Input.GetAxis("Mouse ScrollWheel") > zoomOut / 10)
            {
                currentPoint.Deactivate();
            }
        }

        //mobile rotate input
        if (currentPoint.enableRotation && Input.touchCount == 1)
        {
            angle += Input.GetTouch(0).deltaPosition.x/10;
        }

        //pc rotate input
        if (currentPoint.enableRotation)
        {
            if (currentPoint.clampRotation)
            {
                if (deltaAngle > currentPoint.minRotation && deltaAngle < currentPoint.maxRotation)
                {
                    Rotate();
                }
                else
                {
                    if (deltaAngle<= currentPoint.minRotation && Input.GetAxis("Horizontal")<0)
                    {
                        Rotate();
                    }
                    if (deltaAngle >= currentPoint.maxRotation && Input.GetAxis("Horizontal") > 0)
                    {
                        Rotate();
                    }
                }
            }
            else
            {
                Rotate();
            }
            
        }

       
    }

    public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles)
    {
        Vector3 dir = point - pivot; // get point direction relative to pivot
        dir = Quaternion.Euler(angles) * dir; // rotate it
        point = dir + pivot; // calculate rotated point
        return point; // return it
    }

    private void Rotate()
    {
        deltaAngle -= Input.GetAxis("Horizontal");
        angle -= Input.GetAxis("Horizontal");
    }

    public void Rotate(float angle)
    {
        deltaAngle -= angle;
        this.angle -= angle;
    }
}
