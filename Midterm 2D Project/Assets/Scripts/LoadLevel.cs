using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField]
    string scenceToLoad;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Action"))
        {
            SceneManager.LoadScene(scenceToLoad);
        }
    }
}
