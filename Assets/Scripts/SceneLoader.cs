using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void FirstLevelLoad()
    {
        SceneManager.LoadScene(2);
        gameObject.SetActive(false);
        GameState gameState = FindObjectOfType<GameState>();
        if(gameState==null)
        {

        }
        else
        {
            gameState.DestroyGameState();
        }
       
    }


    public void OnPressQuit()
    {
        Application.Quit();
    }

    public void Update()
    {

    }
}
