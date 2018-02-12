using UnityEngine;
using System.Collections;

public class ObjectRotator : ConditionChecker
{
	private float baseAngle = 0.0f;
	private float lastAng;
	public float needVal;
    public Transform aimTransform;
    public bool inverse = false;
    private AudioSource source;

    private void Awake()
    {
        if (!aimTransform)
        {
            aimTransform = transform;
        }
        source = GetComponent<AudioSource>();
    }

    void OnMouseDown(){
		Vector3 pos = Camera.main.WorldToScreenPoint(aimTransform.position);
		pos = Input.mousePosition - pos;
		baseAngle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
		baseAngle -= Mathf.Atan2(aimTransform.right.y, aimTransform.right.x) *Mathf.Rad2Deg;
		lastAng = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;
	}

	void OnMouseDrag(){
		Vector3 pos = Camera.main.WorldToScreenPoint(aimTransform.position);
		pos = Input.mousePosition - pos;
		float ang = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;

        if (inverse)
        {
            ang = -ang;
        }

        if (lastAng - ang == 0)
        {
            source.pitch = 0;
        }
        else
        {
            source.pitch = 1;
        }

        aimTransform.Rotate(Vector3.forward*(lastAng-ang), Space.Self);

		lastAng = ang;

		float rot = aimTransform.localRotation.eulerAngles.z;
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

    private void OnMouseUp()
    {
        source.pitch = 0;
    }
}
