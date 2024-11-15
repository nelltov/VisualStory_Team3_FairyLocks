using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class NewBehaviourScript : MonoBehaviour
{
    public int x = 0;
    public VideoPlayer videoPlayer;
    public VideoClip[] videoClips;
    public RawImage image;

    public AudioSource ring;

    void Start()
    {
        ring.Play();
    }
    public void PlayManager(int order)
    {
        ring.Stop();
        image.gameObject.SetActive(true);
        if (order >= 0 && order < videoClips.Length)
        {
            videoPlayer.clip = videoClips[order]; 
            videoPlayer.Play();
        }
        x+=1;
        StartCoroutine(EndVideo((float)videoPlayer.clip.length));
    }

    public void Call()
    {

        PlayManager(x);
                
    }

    IEnumerator EndVideo(float time)
    {
        yield return new WaitForSeconds(time);
        image.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (videoPlayer != null && !videoPlayer.isPlaying && videoPlayer.isPrepared)
        {
            image.gameObject.SetActive(false);
        }
        */
    }
}
