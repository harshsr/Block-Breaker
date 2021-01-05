using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DestroyBlocks : MonoBehaviour
{
    LevelBehaviour levelBehaviour;
    GameState gameState;

    [SerializeField] AudioClip destroySound;
    [SerializeField] GameObject destroyVFX;
    [SerializeField] int hitpoints;
    [SerializeField] Sprite[] breakSprites;

    int pointsToAddToScore;
    int currentHits;
    float spriteScale

    // Start is called before the first frame update
    void Start()
    {
        levelBehaviour = FindObjectOfType<LevelBehaviour>();
        levelBehaviour.addBlock();

        currentHits = 0;

        pointsToAddToScore = 5 * hitpoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentHits++;

        if(currentHits==hitpoints)
        {
            DestroBlock();
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = breakSprites[currentHits-1];
        }
    }

    private void DestroBlock()
    {
        PlayDestroyVfx();

        gameState = FindObjectOfType<GameState>();
        gameState.AddScore(pointsToAddToScore);

        levelBehaviour.deleteBlock();

        AudioSource.PlayClipAtPoint(destroySound, transform.position);

        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    private void PlayDestroyVfx()
    {
        Instantiate(destroyVFX, gameObject.transform.position,transform.rotation);
    }
}
