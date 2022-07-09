using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class videoController : MonoBehaviour
{
    public GameObject videoPlayer;
    UnityEngine.Video.VideoPlayer player;
    public GameObject videoPlayerButtonContainer;
    public UnityEngine.UI.Button showVideoButton;
    public UnityEngine.UI.Button threeD_Button;
    public string modelPath;
    
    
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.SetActive(false);
        videoPlayerButtonContainer.SetActive(false);    
        showVideoButton.gameObject.SetActive(false);
        threeD_Button.gameObject.SetActive(false); 
        player = videoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>();
        

        if (player != null)
       {          
            player.Stop();          
       }
    }

    public void playListener()
    {
        player.Play();
    }

    public void pauseListener()
    {
        player.Pause();
    }
    public void resetListener()
    {
        player.Stop();
        player.Play();
    }

    public void showVideoPlayerListener()
    {
        videoPlayer.SetActive(true);
        videoPlayerButtonContainer.SetActive(true);
        player.Play();
    }


    public void ontragetLost()
    {
        videoPlayer.SetActive(false);
        showVideoButton.gameObject.SetActive(false);
        videoPlayerButtonContainer.SetActive(false);
        threeD_Button.gameObject.SetActive(false);
        player.Stop();
    }

    public void ontragetFound()
    {
        showVideoButton.gameObject.SetActive(true);
        threeD_Button.gameObject.SetActive(true);
    }

    public void ThreeD_Mode()
    {
                
        SceneManager.LoadScene(1);
        NotDestroyGameObj.path = modelPath;
    }

}
