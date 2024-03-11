using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody2D rB2D = null;

    public float movementSpeed = 5.0f;
    public float jumpForce = 100.0f;

    [SerializeField]
    private int variableDeTest = 100;

    // Start is called before the first frame update
    void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        Debug.Log($"El valor horitzontal és {horizontalMovement}");

        if (rB2D != null) 
        {
            rB2D.velocity = new Vector2(horizontalMovement * movementSpeed, rB2D.velocity.y);
        }
        /*if(Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movementSpeed, 0);
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 0));
            //transform.position += new Vector3(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, 0);
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 0));
        }*/

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
    }
}
