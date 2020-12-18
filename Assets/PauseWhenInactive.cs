using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class PauseWhenInactive : MonoBehaviour
{
    public GameObject mediaPlayer;
    public GameObject Trigger;

    // exactly what it says on the tin: this pauses the media player when the trigger is inactive. 
    void Update()
    {
        if (Trigger.activeSelf == false)
		{
            mediaPlayer.GetComponent<MediaPlayer>().Pause();  
        }
    }
}
