
using UnityEngine;

public class movement : MonoBehaviour
    
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideSpeed = 500f;
    
    void FixedUpdate()
    //fixedupdate is cooler than just update
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            rb.AddForce(sideSpeed*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            rb.AddForce(-sideSpeed*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
