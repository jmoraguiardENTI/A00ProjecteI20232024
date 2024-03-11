using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Rigidbody2D rB2D = null;

    [SerializeField]
    private bool isGrounded = false;
    [SerializeField] 
    private Vector3 groundCheckOrigin;
    [SerializeField]
    private float groundCheckDistance;

    [SerializeField]
    private float movementSpeed = 5.0f;

    [SerializeField]
    private float jumpForce = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Get a reference to the Rigid Body 2D GameObject´s component
        rB2D = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called in a constant rate
    private void FixedUpdate()
    {
        //Use Physics Raycast to detect if we are close to ground
        RaycastHit2D hit2D = Physics2D.Raycast(transform.position + groundCheckOrigin, Vector2.down, groundCheckDistance, LayerMask.GetMask("Floor"));
        isGrounded = hit2D? true: false;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    // All mavement input is controlled here
    void Movement()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        // Check for null Rigid Body 2D to avoid illegal calls
        if (rB2D != null)
        {
            rB2D.velocity = new Vector2(horizontalMovement * movementSpeed, rB2D.velocity.y);

            if (isGrounded && Input.GetButtonDown("Jump"))
            {
                rB2D.AddForce(new Vector2(0, jumpForce));
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawLine(transform.position + groundCheckOrigin, transform.position + (groundCheckOrigin + Vector3.down * groundCheckDistance));
    }
}
