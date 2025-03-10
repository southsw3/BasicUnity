using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 2.0f;
    public float jumpForce = 15f;
    private Rigidbody rb;
    private bool isGrounded;
    private int jumpCount = 0;
    private int maxJumps = 3;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& jumpCount < maxJumps)
        {
            rb.linearVelocity = new Vector3(rb.angularVelocity.x, 0f, rb.angularVelocity.z);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpCount++;
            isGrounded = false;
        }

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ) * speed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
        
    }

    
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            //isGrounded = true;
            jumpCount = 0;
        }
    }
}
