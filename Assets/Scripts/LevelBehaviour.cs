using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehaviour : MonoBehaviour
{
    private int breakableBlocks;
    SceneLoader sceneLoader;

    // Start is called before the first frame update
    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(breakableBlocks);
        if (breakableBlocks==0)
        {
            sceneLoader.LoadNextLevel();
        }
    }

    public void addBlock()
    {
        breakableBlocks++;
    }

    public void deleteBlock()
    {
        breakableBlocks--;
    }
}
