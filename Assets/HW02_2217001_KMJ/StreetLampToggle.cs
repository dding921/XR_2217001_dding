using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetLampToggle : MonoBehaviour
{
    public Light lampLight;

    private bool isOn = true;

    void Start()
    {
        // AppState에서 이전 가로등 상태 복원
        isOn = AppState.Instance != null ? AppState.Instance.isStreetLampOn : true;
        lampLight.enabled = isOn;
    }

    void OnMouseDown()
    {
        isOn = !isOn;
        lampLight.enabled = isOn;

        // AppState에 현재 상태 저장
        if (AppState.Instance != null)
        {
            AppState.Instance.isStreetLampOn = isOn;
        }
    }
}
