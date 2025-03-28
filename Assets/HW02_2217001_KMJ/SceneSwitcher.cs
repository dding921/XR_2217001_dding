using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToOutdoor()
    {
        SceneManager.LoadScene("HW02_2217001_KMJ");
    }

    public void GoToIndoor()
    {
        SceneManager.LoadScene("SecondScene");
    }
}
