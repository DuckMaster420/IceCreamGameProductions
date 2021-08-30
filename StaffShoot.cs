using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffShoot : MonoBehaviour
{
    private Animator Animations;

    void Start()
    {
        Animations = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("q"))
        {
            Animations.Play("staffShootAnimation");

            Animations.Play("New State");
        }
    }
}
