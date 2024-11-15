using UnityEngine;
using UnityEngine.UI;

public class FilterManager : MonoBehaviour
{
    public Image panel;
    [SerializeField] public Button publishButton;
    [SerializeField] public ParticleSystem thumb;

    void Start()
    {
        publishButton.interactable = false;
        thumb.Stop();
    }

    public void Filter1()
    {
        panel.color = Color.red;
        publishButton.interactable = true;
    }

    public void Filter2()
    {
        panel.color = Color.yellow;
        publishButton.interactable = true;
    }

    public void Filter3()
    {
        panel.color = Color.green;
        publishButton.interactable = true;
    }

    public void Publish()
    {
        thumb.Play();
    }

}
