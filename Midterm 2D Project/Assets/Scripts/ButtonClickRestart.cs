using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClickRestart : MonoBehaviour
{
    public void RestartGameButtonClicked()
    {
        SceneManager.LoadScene("Title Scene");
    }
}
