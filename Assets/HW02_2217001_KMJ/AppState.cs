using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppState : MonoBehaviour
{
    public static AppState Instance;

    public bool isRadioOn = false;
    public bool isTVOn = true;
    public bool isStreetLampOn = true;
    public bool isBillboardOn = true;
    public bool isLampOn = false;
    public bool isBirdSoundOn = true;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
