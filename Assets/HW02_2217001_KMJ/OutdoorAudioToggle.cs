using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutdoorAudioToggle : MonoBehaviour
{
    public AudioSource outdoorAudio;

    void Start()
    {
        // AppState에서 새소리 상태 복원
        if (AppState.Instance != null && outdoorAudio != null)
        {
            if (AppState.Instance.isBirdSoundOn)
                outdoorAudio.Play();
            else
                outdoorAudio.Pause();
        }
    }

    private void OnMouseDown()
    {
        if (outdoorAudio != null)
        {
            if (outdoorAudio.isPlaying)
            {
                outdoorAudio.Pause();
                AppState.Instance.isBirdSoundOn = false;
            }
            else
            {
                outdoorAudio.Play();
                AppState.Instance.isBirdSoundOn = true;
            }
        }
    }
}
