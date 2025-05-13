using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D12_Instantiator : MonoBehaviour

{
    public GameObject TargetObject;

    int cloneCount = 10;



    void Start()
    {
        InstantiateHearts();
    }

    
    void Update()
    {
        
    }


    void InstantiateHearts()
    {
        for(int i=0; i< cloneCount; i++)
        {

            //랜덤 포지션 만들기
            Vector3 randomSphere = Random.insideUnitSphere * 5;
            randomSphere.y = 0f;
            Vector3 randomPos = randomSphere + transform.position;

            //랜덤 각도 만들기(y축만)
            float randomAngle = Random.value * 360f;
            Quaternion randomRot = Quaternion.Euler(0, randomAngle, 0);


            GameObject clone = Instantiate(TargetObject, randomPos, randomRot);
            clone.transform.SetParent(transform);
        }
    }


}
