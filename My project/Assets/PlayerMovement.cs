using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check for horizontal and vertical input
        //move the player based on that input
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        //velocity is a Vector2 variable, storing 2 floats, x and y
        GetComponent<Rigidbody2D>().velocity = new Vector2 (xInput, yInput) * moveSpeed;
    }
}
