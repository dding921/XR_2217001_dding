using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReloadScene : MonoBehaviour
{
    public void OnClick_Loadscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
