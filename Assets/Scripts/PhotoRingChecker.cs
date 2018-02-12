using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoRingChecker : ConditionChecker
{
    public float rotSpeed = 1;
    private Vector2 lastPosition;


    private void OnMouseDown()
    {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast (ray, out hit)) 
		{
			lastPosition = hit.collider.transform.InverseTransformPoint(hit.point);
		}
    }

    void OnMouseDrag()
    {
		Vector3 newPosition = Camera.main.ScreenToWorldPoint (new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));
		newPosition = transform.InverseTransformVector (newPosition);
		Debug.Log (newPosition*1000);
    }
}