using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 30.0f; // Speed of the vehicle
    [SerializeField] private float turnSpeed = 50.0f; // Speed at which the vehicle turns
    private float horizontalInput; // Input for horizontal movement
    private float forwardInput; // Input for forward movement
 
    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotate the vehicle based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed* horizontalInput * Time.deltaTime);
    }
}
