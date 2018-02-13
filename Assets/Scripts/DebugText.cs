using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugText :Singleton<DebugText> {

	public void Log(string s)
    {
        if (GetComponent<Text>().text.Split('\n').Length>10)
        {
            GetComponent<Text>().text = "";
        }
        GetComponent<Text>().text += s+ "\n";
    }
}
