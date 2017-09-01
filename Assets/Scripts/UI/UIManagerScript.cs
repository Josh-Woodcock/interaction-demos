using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour {

    public void StartHTC()
    {
        SceneManager.LoadScene("HTCViveControllersDemoRoom");
    }

    public void StartLEAP()
    {
        SceneManager.LoadScene("LEAPMotionDemoRoom");
    }

public void StartVRTK()
    {
        SceneManager.LoadScene("VRTKDemoRoom");
    }
}
