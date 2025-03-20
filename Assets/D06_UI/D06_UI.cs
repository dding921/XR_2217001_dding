using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D06_UI : MonoBehaviour
{
    public void OnClick_Destroy(GameObject Target)
    {
        Destroy(Target);
    }

    public void OnClick_Loadscene()
    {
        SceneManager.LoadScene(0);
   
    }
}
