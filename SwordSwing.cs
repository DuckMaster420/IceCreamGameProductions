using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    private Animator Animation;

    void Start()
    {
        Animation = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Animation.Play("SwordAnimationTest");

            Animation.Play("New State");
        }
    }
}
