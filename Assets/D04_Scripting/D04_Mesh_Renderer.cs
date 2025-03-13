using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D04_Mesh_Renderer : MonoBehaviour
{
    MeshFilter ThisMeshFilter;
    public GameObject MyCapsule, MySphere;

    // Start is called before the first frame update
    void Start()
    {
        ThisMeshFilter = GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//마우스는 0이랑 1로 설정(0이 왼쪽 버튼)
        {
            ThisMeshFilter.mesh = MyCapsule.gameObject.GetComponent<MeshFilter>().mesh;
        }
        if (Input.GetMouseButtonDown(1))
        {
            ThisMeshFilter.mesh = MySphere.gameObject.GetComponent<MeshFilter>().mesh;
        }
    }
}
