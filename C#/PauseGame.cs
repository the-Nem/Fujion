using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool GameIsPaused = false;

    public static void Resume()
    {
        Time.timeScale = 1f;
    }
    public static void Pause()
    {
        Time.timeScale = 0f;
    }
}
