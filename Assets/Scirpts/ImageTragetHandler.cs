using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ImageTragetHandler : MonoBehaviour
{
    public GameObject videoPlayer;
    public string modelPath;
    public GameObject myScript;
    ButtonController buttonController;
    private void Start()
    {
        //ButtonController buttonController = myScript.GetComponent<ButtonController>();
    }

    public void onTragetFound()
    {
       // if(buttonController != null)
        {
            ButtonController.videoPlayer = videoPlayer;
            ButtonController.modelPath = modelPath;
            Debug.Log(videoPlayer + " Image");
        }
    }
}
