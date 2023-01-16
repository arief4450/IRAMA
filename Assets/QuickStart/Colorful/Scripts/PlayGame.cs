using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public string SceneName;

    public void playGame()
    {
        Scene thisScene = SceneManager.GetActiveScene();

        if (thisScene.name != SceneName)
        {
            SceneManager.LoadScene(SceneName);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneName);
    }
}
