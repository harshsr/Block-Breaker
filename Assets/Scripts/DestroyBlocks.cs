using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlocks : MonoBehaviour
{
    LevelBehaviour levelBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        levelBehaviour = FindObjectOfType<LevelBehaviour>();
        levelBehaviour.addBlock();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        levelBehaviour.deleteBlock();
        Destroy(gameObject);
    }
}
