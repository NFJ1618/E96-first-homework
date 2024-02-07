using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isPaused = false;

    // Function to be called when the pause button is pressed
    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0; // This pauses the game
        }
        else
        {
            Time.timeScale = 1; // This resumes the game
        }
    }
}

