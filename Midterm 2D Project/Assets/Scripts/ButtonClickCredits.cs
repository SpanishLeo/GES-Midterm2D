using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClickCredits : MonoBehaviour
{
    public void CreditsButtonClicked()
    {
        SceneManager.LoadScene("Credits Scene");
    }
}
