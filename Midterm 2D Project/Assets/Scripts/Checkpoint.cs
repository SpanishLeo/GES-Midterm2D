using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    public static Checkpoint currentCheckpoint;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        DeactivateCheckpoint();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(currentCheckpoint != this)
            {
                if (currentCheckpoint != null)
                {
                    currentCheckpoint.DeactivateCheckpoint();
                }
                ActivateCheckpoint();
            }
        }
    }

    private void ActivateCheckpoint()
    {
        Debug.Log("Checkpoint Reached");
        spriteRenderer.enabled = true;
        currentCheckpoint = this;
    }

    private void DeactivateCheckpoint()
    {
        spriteRenderer.enabled = false;
    }
}
