﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    // Step 1: declare variables
    private AudioSource audioSource;
    private BoxCollider2D boxCollider2D;
    private SpriteRenderer spriteRenderer;


    // make this static, so that there's only one coinCount that belongs
    // to the entire Coin class as a whole.
    // as opposed to one per instance of Coin
    public static int chestsCollected = 0;

    private void Start()
    {
        // Step 2: initialize variables
        //audioSource = GetComponent<AudioSource>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Chest Collected");
            //audioSource.Play();
            boxCollider2D.enabled = false;
            spriteRenderer.enabled = false;

            //float length = audioSource.clip.length + 0.2f;

            // Increment coint count!
            chestsCollected++;

            Debug.Log("Chests Collected: " + chestsCollected);

            Destroy(gameObject);
        }
    }
}
