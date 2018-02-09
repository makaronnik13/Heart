using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleChecker : ConditionChecker {

    public ConditionChecker[] checkers;

	// Use this for initialization
	void Start ()
    {
        foreach (ConditionChecker c in checkers)
        {
            c.onChecked.AddListener(Checked);
        }
	}

    private void Checked()
    {
        bool on = true;
        foreach (ConditionChecker c in checkers)
        {
            if (!c.On)
            {
                on = false;
            }
        }

        Check(on);
    }

    public void Test()
    {
        Debug.Log("!!!");
    }
}
