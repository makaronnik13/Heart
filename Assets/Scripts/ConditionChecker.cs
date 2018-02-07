using UnityEngine;
using UnityEngine.Events;

public class ConditionChecker: MonoBehaviour
{
    public UnityEvent onChecked;
    public MonoBehaviour[] disablingScripts;
    public Collider[] disablingColliders;

    [HideInInspector]
    public bool On = false;

    protected void Check(bool val)
    {

        On = val;

        if (val)
        {
            onChecked.Invoke();
            foreach (MonoBehaviour mb in disablingScripts)
            {
                mb.enabled = false;
            }
            foreach (Collider c in disablingColliders)
            {
                Destroy(c);
            }

        }
    }
}