using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
        // Set up the UI for editing sequence #1 
        // Wait until player clicks "publish" on editing video #1
        // Show feedback #1 for a couple seconds

        // Play call #2 and wait for the call to be done
        // Set up the UI for editing sequence #2
        // Wait until the player finishes the second editing sequence
        // Show feedback #2 for a couple seconds

        // Play call #3 and wait for the call to be done
        // Set up the UI for editing sequence #3
        // Wait until the player finishes the third editing sequence
        // Show feedback #3 for a couple seconds

        // Play call #4 and wait for the call to be done
        // Set up the UI for editing sequence #4
        // Wait until the player clicks "publish" on editing video #4
        // Show feedback #4 for a couple seconds

        // Play call #5 and wait for the call to be done
        // Set up the UI for editing sequence #5 (two choices for player)
        // Wait until player clicks either "publish" or "delete" on editing video #5
        // Play either ending based on whether the player clicked "publish" or "delete"
    }
}
