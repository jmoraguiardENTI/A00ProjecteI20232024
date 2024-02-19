using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float jumpForce = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movementSpeed, 0);
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 0));
            //transform.position += new Vector3(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, 0);
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 0));
        }

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
    }
}
