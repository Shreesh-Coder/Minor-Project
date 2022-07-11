using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public static GameObject videoPlayer;
    UnityEngine.Video.VideoPlayer player;
    public GameObject videoPlayerButtonContainer;
    public UnityEngine.UI.Button showVideoButton;
    public UnityEngine.UI.Button threeD_Button;
    public static string modelPath;


    // Start is called before the first frame update
    void Start()
    {

       
        videoPlayerButtonContainer.SetActive(false);
        showVideoButton.gameObject.SetActive(false);
        threeD_Button.gameObject.SetActive(false);
        


        if (player != null)
        {
            player.Stop();
        }
    }

    public void showVideoPlayerListener()
    {
        videoPlayer.SetActive(true);
        videoPlayerButtonContainer.SetActive(true);
        player.Play();
    }


    public void ontragetLost()
    {
        if(videoPlayer != null)
            videoPlayer.SetActive(false);
        showVideoButton.gameObject.SetActive(false);
        videoPlayerButtonContainer.SetActive(false);
        threeD_Button.gameObject.SetActive(false);
        if(player != null)
            player.Stop();
    }

    public void ontragetFound()
    {
        
        showVideoButton.gameObject.SetActive(true);
        threeD_Button.gameObject.SetActive(true);
        if (videoPlayer != null)
        {
            Debug.Log(videoPlayer.name);
            player = videoPlayer.GetComponent<UnityEngine.Video.VideoPlayer>();

        }
    }

    public void ThreeD_Mode()
    {
        NotDestroyGameObj.path = modelPath;
        SceneManager.LoadScene(1);        
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


}
