using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float speed = 12f;
    private Vector3 velocity;

    private CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void PlayerMove() {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);
    }



    void Update()
    {
        PlayerMove(); 
    }
}
