using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody rigb; 

    void Start()
    {
        rigb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

            float moveHoriz = Input.GetAxis("Horizontal");
            float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHoriz, 0.0f, moveVert);
        rigb.AddForce(movement * speed);
    }
}
