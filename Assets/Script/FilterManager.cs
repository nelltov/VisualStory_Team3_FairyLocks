using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class FilterManager : MonoBehaviour
{
    public RawImage panel;
    public VideoPlayer videoplayer;
    public int x;
    [SerializeField] public Button publishButton;
    [SerializeField] public Button[] filterButtons;
    [SerializeField] public ParticleSystem thumb;

    void Start()
    {
        InitializeFilterUI();
        publishButton.interactable = false;
        thumb.Stop();
    }

    public void Filter(int i)
    {
        videoplayer.Stop();
        Debug.Log($"Yas1/video{i}");

        VideoClip videoClip = Resources.Load<VideoClip>($"Yas1/video{i}");
        videoplayer.clip = videoClip;
        videoplayer.Play();

        publishButton.interactable = true;
    }

    public void InitializeFilterUI()
    {
        // load in video0 into panel
        VideoClip videoClip = Resources.Load<VideoClip>($"Yas1/video0");
        videoplayer.clip = videoClip;
        videoplayer.Play();

        for (int i = 0; i < filterButtons.Length; i++) 
        {
            int index = i;
            Button filterButton = filterButtons[i];
            filterButton.onClick.AddListener(() => Filter(index + 1));
        }
    }

    public void Publish()
    {
        videoplayer.Stop();
        thumb.Play();
    }

}
