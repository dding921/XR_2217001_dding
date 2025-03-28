using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class TVMaterialToggle : MonoBehaviour
{
    public Renderer screenRenderer;          // TV 화면
    public Material onMaterial;              // 영상이 나오는 머티리얼 (RenderTexture 연결됨)
    public Material offMaterial;             // 꺼졌을 때 머티리얼
    public VideoPlayer videoPlayer;          // VideoPlayer 컴포넌트

    private bool isOn = false;

    void Start()
    {
        // StreamingAssets 경로로 영상 URL 설정
        string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, "267747.mp4");
        videoPlayer.url = videoPath;
        videoPlayer.Prepare();  // 영상 미리 불러오기

        // AppState 값에 따라 TV 상태 복원
        isOn = AppState.Instance != null ? AppState.Instance.isTVOn : false;

        screenRenderer.material = isOn ? onMaterial : offMaterial;

        if (isOn)
        {
            videoPlayer.Play();
        }
        else
        {
            videoPlayer.Pause();
        }
    }

    void OnMouseDown()
    {
        isOn = !isOn;

        // Material 전환
        screenRenderer.material = isOn ? onMaterial : offMaterial;

        // 영상 재생/정지
        if (isOn)
        {
            videoPlayer.Play();
        }
        else
        {
            videoPlayer.Pause();
        }

        // AppState에 현재 TV 상태 저장
        if (AppState.Instance != null)
        {
            AppState.Instance.isTVOn = isOn;
        }
    }
}
