using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioClickToggle : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        // AppState에서 라디오 상태 복원
        if (audioSource != null && AppState.Instance != null)
        {
            if (AppState.Instance.isRadioOn)
                audioSource.Play();
            else
                audioSource.Pause();
        }
    }

    private void OnMouseDown()
    {
        if (audioSource != null)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
                AppState.Instance.isRadioOn = false;
            }
            else
            {
                audioSource.Play();
                AppState.Instance.isRadioOn = true;
            }
        }
    }
}
