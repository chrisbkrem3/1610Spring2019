using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{

    public UnityEvent OnGrounded, OffGrounded;

    public float Speed = 3;
    public float Gravity = -9.81f;


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


        position.y += Gravity * Time.deltaTime;

          if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
          {
              position.y = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
          }
          else
          {
             position.y = Gravity * Time.deltaTime;
         }


        position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;




        Controller.Move(position);
      
    }
}
