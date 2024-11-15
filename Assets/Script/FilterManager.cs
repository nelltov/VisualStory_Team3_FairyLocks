using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class FilterManager : Singleton<FilterManager>
{
    public RawImage panel;
    public VideoPlayer videoplayer;
    public int x;
    public int flagValue = 1;

    public bool flag = false, feedback = true;
    [SerializeField] public Button publishButton;
    [SerializeField] public Button[] filterButtons;
    [SerializeField] public ParticleSystem thumb, thumbdown;

    void Start()
    {
        panel.enabled = false;
        videoplayer.clip = null;
        publishButton.interactable = false;
        thumb.Stop();
        thumbdown.Stop();
        // InitializeFilterUI();
    }

    public void Filter(int i)
    {
        videoplayer.Stop();

        VideoClip videoClip = Resources.Load<VideoClip>($"Yas{x}/video{i}");
        videoplayer.clip = videoClip;
        videoplayer.Play();

        // Set flag to true if i == flagValue and false otherwise
        flag = (i == flagValue);
        
        publishButton.interactable = true;
    }

    public void InitializeFilterUI()
    {
        publishButton.interactable = false;
        thumb.Stop();
        thumbdown.Stop();
        panel.enabled = true;
        // load in video0 into panel
        VideoClip videoClip = Resources.Load<VideoClip>($"Yas{x}/video0");
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
        panel.enabled = false;
        if(flag)
        {
            if(feedback)
            {
                thumb.Play();
            }
            else
            {
                thumbdown.Play();
            }

            if (x == 1) 
            {
                GameManager.Instance.introVideoPublished = true;
            }
            else if (x == 4) 
            {
                GameManager.Instance.activismVidPublished = true;
            }
            
        }
        else {
            Debug.Log("That's not the right filter!");
        }

        
    }

}
