using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Relauncher : MonoBehaviour {

    private bool finishing;
    public FocusPoint basePoint;

	public void Relaunch()
    {
        basePoint.Activate();
        finishing = true;
        foreach (Collider c in FindObjectsOfType<Collider>())
        {
            c.enabled = false;
        }
        Invoke("ReloadScene", 20);
    }

    private void ReloadScene()
    {
        SceneManager.LoadSceneAsync(0);
    }

    private void Update()
    {
        if (finishing)
        {
            GetComponent<CameraController>().Rotate(0.2f);
        }
    }
}
