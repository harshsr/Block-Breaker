using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    [Range(0.1f,5f)][SerializeField] float gameSpeed;
    [SerializeField] Text text;


    int currentScore = 0;

    private void Awake()
    {
        int gameStateCount = FindObjectsOfType<GameState>().Length;
        if (gameStateCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
        text.GetComponent<UnityEngine.UI.Text>().text = currentScore.ToString();
    }

    public void AddScore(int points)
    {
        currentScore += points;
    }


    public void DestroyGameState()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
