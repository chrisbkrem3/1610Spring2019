using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JumpCharacter : MonoBehaviour
{

    public UnityEvent OnGrounded, OffGrounded;

    public float Speed = 3;
    public float Gravity = -9.81f;
    public float JumpForce = 30;

    public CharacterController Controller;
    private Vector3 position;



    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

   
    void Update()
    {
        if (Controller.isGrounded)
        {
            OnGrounded.Invoke();
        }
        else
        {
            OffGrounded.Invoke();
        }
        if (Controller.isGrounded && Input.GetButton("Jump"))
        {
            position.y = JumpForce * Time.deltaTime;
        }

        position.y += Gravity * Time.deltaTime;

        position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        Controller.Move(position);
    }
}
