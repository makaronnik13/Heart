using UnityEngine;
using System.Collections;

public class ObjectRotator : ConditionChecker
{
	private float baseAngle = 0.0f;
	private float lastAng;
	public float needVal;


	void OnMouseDown(){
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		pos = Input.mousePosition - pos;
		baseAngle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
		baseAngle -= Mathf.Atan2(transform.right.y, transform.right.x) *Mathf.Rad2Deg;
		lastAng = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;
	}

	void OnMouseDrag(){
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		pos = Input.mousePosition - pos;
		float ang = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;

		transform.Rotate(Vector3.forward*(lastAng-ang), Space.Self);

		lastAng = ang;

		float rot = transform.localRotation.eulerAngles.z;
		if(rot<0)
		{
			rot = 360 + rot;
		}
		if(rot>=360)
		{
			rot = rot - 360;
		}

		Check(Mathf.Abs(rot- needVal)<5);
	}
		
}
