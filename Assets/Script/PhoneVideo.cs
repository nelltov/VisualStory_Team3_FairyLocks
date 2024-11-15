using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PhoneVideo : Singleton<PhoneVideo>
{
    public int x = 0;
    public VideoPlayer videoPlayer;
    public RawImage image;

    public AudioSource ring;

    private void Start()
    {
        image.gameObject.SetActive(false);
    }

    public void PlayManager(int order)
    {
        ring.Stop();
        image.gameObject.SetActive(true);
        if (order >= 0 && order < 5)
        {
            VideoClip videoClip = Resources.Load<VideoClip>($"ManagerCalls/manager_{order + 1}");
            videoPlayer.clip = videoClip;
            videoPlayer.Play();
        }
        StartCoroutine(EndVideo((float)videoPlayer.clip.length));
    }

    public void Call()
    {
        StartCoroutine(StartCall());
    }

    private IEnumerator StartCall()
    {
        ring.Play();
        yield return new WaitForSeconds(3);
        PlayManager(x);
    }

    private IEnumerator EndVideo(float time)
    {
        yield return new WaitForSeconds(time);
        image.gameObject.SetActive(false);

        // alert the GameManager that the call has been played
        GameManager.Instance.managerCallsPlayed[x] = true; 
        x += 1;
    }
}
