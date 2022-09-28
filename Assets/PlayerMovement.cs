using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce;
    public float sidewardForce;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, forwardForce * Time.deltaTime);
        if(Input.GetKey("d")){
            rb.AddForce(sidewardForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sidewardForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
    }
}
