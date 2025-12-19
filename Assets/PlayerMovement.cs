using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed = 5f;
    private Rigidbody rb;

    private Vector2 movementInput = Vector2.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(movementInput.x,0, movementInput.y) * moveSpeed);
    }
    private void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {   
            other.gameObject.SetActive(false);
        }
    }
}
