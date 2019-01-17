using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ClickOnMe : MonoBehaviour {

    public VideoPlayer player;
    public VideoClip clip;
    public AudioSource audioSource;


    private void Start()
    {
        player.audioOutputMode = VideoAudioOutputMode.AudioSource;
        player.SetTargetAudioSource(0, audioSource);
        player.source = VideoSource.VideoClip;
        player.clip = clip;
    }

    bool active = false;
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (!active)
        {
            player.Play();
            Debug.Log("ON!");
        } else
        {
            player.Stop();
            Debug.Log("OFF");
        }
        active = !active;
    }

   
}
