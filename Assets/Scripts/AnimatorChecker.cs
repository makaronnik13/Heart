using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorChecker : ConditionChecker {

    public Animator[] animators;
    public string[] needNames;

	// Update is called once per frame
	void Update () {
        bool val = true;

        int i = 0;
        foreach (Animator a in animators)
        {
            if (!a.GetCurrentAnimatorStateInfo(0).IsName(needNames[i]))
            {
                val = false;
            }
            i++;
        }

        Check(val);
	}

}
