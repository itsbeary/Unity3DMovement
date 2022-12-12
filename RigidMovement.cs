using UnityEngine;

public class RigidMovement : MonoBehaviour
{
    public float speed = 7.0f;
    public float sensitivity = 1000f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection = transform.TransformDirection(movementDirection);

        rb.velocity = movementDirection * speed;
        float mouseX = Input.GetAxis("Mouse X");

        transform.Rotate(0f, mouseX * sensitivity * Time.deltaTime, 0f, Space.Self);
    }
}

