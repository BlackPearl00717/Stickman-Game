using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceArms : MonoBehaviour
{
    public float targetRotation;
    public Rigidbody2D rb;
    public float force;
    public float stop;
    public KeyCode mousebutton;

    public void disable()
    {
        force = 0;
    }
    public void Update()
    {
        if (!Input.GetKey(mousebutton))
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, targetRotation, force * Time.fixedDeltaTime));
        }
    }
}