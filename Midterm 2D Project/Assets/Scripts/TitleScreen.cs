using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void StartGameButtonClicked()
    {
        SceneManager.LoadScene("Midterm 2D Scene");
    }


}
