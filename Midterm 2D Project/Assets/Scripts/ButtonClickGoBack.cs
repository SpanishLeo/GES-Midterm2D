using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClickGoBack : MonoBehaviour
{
    public void GoBackButtonClicked()
    {
        SceneManager.LoadScene("End Scene");
    }
}
