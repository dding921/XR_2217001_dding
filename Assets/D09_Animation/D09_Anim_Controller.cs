using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class D09_Anim_Controller : MonoBehaviour
{
    public Animator animator;
    public Slider slider;


    private void Start()
    {
        slider.value = 0;
        animator.speed = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.speed = 1f;
            slider.value = 1;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {

            animator.speed = 0f;
            slider.value = 0;
        }
    }


    public void OnSlider_SetValue()
    {
        animator.speed = slider.value;
    }




}
