using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class News : Singleton<News>
{
    public Image news;
    public AudioSource NewsSound;
    private Animator animator;
    // Start is called before the first frame update
    public void newspop()
    {
        StartCoroutine(popnews());
    }

    IEnumerator popnews()
    {
        animator = news.GetComponent<Animator>();
        yield return new WaitForSeconds(6);
        FilterManager.Instance.thumb.Stop();
        FilterManager.Instance.thumbdown.Stop();
        NewsSound.Play();
        news.gameObject.SetActive(true);
        animator.SetTrigger("1");
    }
}
