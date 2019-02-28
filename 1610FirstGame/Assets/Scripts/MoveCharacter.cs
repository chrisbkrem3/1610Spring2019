using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public float Speed = 3;


    public CharacterController Controller;
    private Vector3 position;

    void Start()
    {
        Controller = GetComponent<CharacterController>();  
    }


    void Update()
    {
        position.y = Input.GetAxis("Vertical")*Speed*Time.deltaTime;
        position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        Controller.Move(position);
      
    }
}
