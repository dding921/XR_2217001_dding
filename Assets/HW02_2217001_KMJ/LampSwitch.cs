using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D07_LampSwitch : MonoBehaviour
{
    public GameObject LampOn, LampOff;

    bool isOn = false;

    private void Start()
    {
        // AppState에서 상태 복원
        isOn = AppState.Instance != null ? AppState.Instance.isLampOn : false;

        if (isOn)
        {
            LampOn.SetActive(true);
            LampOff.SetActive(false);
        }
        else
        {
            LampOn.SetActive(false);
            LampOff.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        print("Mouse Down");

        isOn = !isOn;

        if (isOn)
        {
            LampOn.SetActive(true);
            LampOff.SetActive(false);
        }
        else
        {
            LampOn.SetActive(false);
            LampOff.SetActive(true);
        }

        // AppState에 상태 저장
        if (AppState.Instance != null)
        {
            AppState.Instance.isLampOn = isOn;
        }
    }
}
