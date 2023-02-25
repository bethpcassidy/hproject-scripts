using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characterold : MonoBehaviour
{
    CharacterController characterController;

    public float Speed = 5f;
    static public bool canMove;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));


        if (canMove == true)
        {

            characterController.Move(move * Time.deltaTime * Speed);

        }
    }
}