using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : Singleton<GameManager>
{
    public bool[] managerCallsPlayed = new bool[5];
    public bool introVideoPublished = false;
    public bool activismVidPublished = false;

    void Start()
    {
        StartCoroutine(GameplayFlow());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private IEnumerator GameplayFlow()
    {
        yield return null; // Wait for the first frame to render and displays to activate

        // TODO: Implement the pseudocode below
        // Set up the UI on main screen and show the cheat sheet

        // Play call #1 and wait for the call to be done
        PhoneVideo.Instance.x = 0;
        PhoneVideo.Instance.Call();
        while (!managerCallsPlayed[0]) yield return null;

        // Set up the UI for editing sequence #1 
        // Wait until player clicks "publish" on editing video #1
        FilterManager.Instance.x = 1;
        FilterManager.Instance.flagValue = 1;
        FilterManager.Instance.feedback = true;
        FilterManager.Instance.InitializeFilterUI();
        while (!introVideoPublished) yield return null;
        
        // TODO: Show feedback #1 for a couple seconds


        // Play call #2 and wait for the call to be done
        PhoneVideo.Instance.x = 1;
        PhoneVideo.Instance.Call();
        News.Instance.newspop();
        while (!managerCallsPlayed[1]) yield return null;

        Debug.Log("Finished the game!");

        // TODO: Set up the UI for editing sequence #2
        // TODO: Wait until the player finishes the second editing sequence
        // TODO: Show feedback #2 for a couple seconds


        //// Play call #3 and wait for the call to be done
        //PhoneVideo.Instance.x = 2;
        //PhoneVideo.Instance.Call();
        //while (!managerCallsPlayed[2]) yield return null;

        //// TODO: Set up the UI for editing sequence #3
        //// TODO: Wait until the player finishes the third editing sequence
        //// TODO: Show feedback #3 for a couple seconds


        //// Play call #4 and wait for the call to be done
        //PhoneVideo.Instance.x = 3;
        //PhoneVideo.Instance.Call();
        //while (!managerCallsPlayed[3]) yield return null;

        //// Set up the UI for editing sequence #4
        //// Wait until the player clicks "publish" on editing video #4
        //FilterManager.Instance.x = 4;
        //FilterManager.Instance.flagValue = 2;
        //FilterManager.Instance.feedback = false;
        //FilterManager.Instance.InitializeFilterUI();
        //while (!activismVidPublished) yield return null;

        //// TODO: Show feedback #4 for a couple seconds


        //// Play call #5 and wait for the call to be done
        //PhoneVideo.Instance.x = 4;
        //PhoneVideo.Instance.Call();
        //while (!managerCallsPlayed[4]) yield return null;

        //// TODO: Set up the UI for editing sequence #5 (two choices for player)
        //// TODO: Wait until player clicks either "publish" or "delete" on editing video #5
        //// TODO: Play either ending based on whether the player clicked "publish" or "delete"
    }
}
