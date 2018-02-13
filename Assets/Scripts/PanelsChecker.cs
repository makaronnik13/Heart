using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelsChecker : ConditionChecker {

    public string messge = "ILOVEYOU";
    private int position;

    private List<GameObject> pushedButtons = new List<GameObject>();

	public void Push(GameObject go)
    {
        if (pushedButtons.Contains(go))
        {
            return;
        }


        if (go.GetComponentInChildren<Text>().text[0] != messge[position])
        {
            foreach (Animator a in GetComponentsInChildren<Animator>())
            {
                if (a.GetCurrentAnimatorStateInfo(0).IsName("LetterButton") || a.gameObject == go.transform.parent.gameObject)
                {
                    a.SetTrigger("Deactive");
                }
            }
            position = 0;
            pushedButtons.Clear();
        }
        else
        {
            position++;
            pushedButtons.Add(go);
        }
        
    }

    private void Update()
    {
        Check(GetComponent<AnimatorChecker>().On);
    }
}
