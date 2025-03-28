using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class BillboardToggle : MonoBehaviour
{
    public VideoPlayer billboardPlayer;
    public Renderer screenRenderer;
    public Material onMaterial;
    public Material offMaterial;

    private bool isScreenOn = true;

    void Start()
    {
        string path = System.IO.Path.Combine(Application.streamingAssetsPath, "snake.mp4");
        billboardPlayer.url = path;
        billboardPlayer.Prepare();

        // AppState에서 화면 On/Off 상태 복원
        isScreenOn = AppState.Instance != null ? AppState.Instance.isBillboardOn : true;

        screenRenderer.material = isScreenOn ? onMaterial : offMaterial;

        // 영상은 켜져 있을 때만 재생
        if (isScreenOn)
        {
            billboardPlayer.Play();
        }
        else
        {
            billboardPlayer.Pause();
        }
    }

    void OnMouseOver()
    {
        // 마우스 오른쪽 클릭 (영상 재생/정지)
        if (Input.GetMouseButtonDown(1))
        {
            if (billboardPlayer.isPlaying)
            {
                billboardPlayer.Pause();
            }
            else
            {
                billboardPlayer.Play();
            }
        }

        // 마우스 왼쪽 클릭 (화면 On/Off)
        if (Input.GetMouseButtonDown(0))
        {
            isScreenOn = !isScreenOn;
            screenRenderer.material = isScreenOn ? onMaterial : offMaterial;

            // 상태 저장
            if (AppState.Instance != null)
            {
                AppState.Instance.isBillboardOn = isScreenOn;
            }

            // 화면 상태에 따라 영상 재생/정지
            if (isScreenOn)
                billboardPlayer.Play();
            else
                billboardPlayer.Pause();
        }
    }
}
