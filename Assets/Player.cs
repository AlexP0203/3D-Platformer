using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float jumpForce = 10;
    [SerializeField] float groundCheckDistance = 1;
    [SerializeField] LayerMask environmentOnly;
    [SerializeField] Animator anim;
    [SerializeField] PlayerStats stats;

    Rigidbody rb;
    float forwardMovementInput;
    float rightMovementInput;
    bool onGround = false;

    Transform cam;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        onGround = (Physics.Raycast(transform.position, Vector3.up * -1, groundCheckDistance, environmentOnly));

        forwardMovementInput = Input.GetAxis("Vertical");
        rightMovementInput = Input.GetAxis("Horizontal");

        

        if(Input.GetButtonDown("Jump") && onGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            anim.SetTrigger("jump");
        }

        Debug.DrawLine(transform.position, //start position
            transform.position + transform.up * -groundCheckDistance, //end position = start + direction * length
            Color.red); //red id red
    }

    private void FixedUpdate()
    {
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camForward.Normalize();

        camRight.y = 0;
        camRight.Normalize();

        Vector3 forwardRelative = forwardMovementInput * camForward;
        Vector3 rightRelative = rightMovementInput * camRight;

        Vector3 movementVector = (forwardRelative + rightRelative) * speed;
        movementVector.y = rb.velocity.y;
        rb.velocity = movementVector;

        anim.SetFloat("speed", movementVector.magnitude);
        anim.transform.forward = movementVector;
    }

    public void damage()
    {
        anim.SetTrigger("hit");

        
    }
    public void death()
    {
        anim.SetTrigger("death");
    }
}
