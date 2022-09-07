using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2;
    [SerializeField]
    private float jumpForce = 400;

    private void fixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
    
        Vector3 movement = new Vector3(horizontal, 0);

        transform.position += movement * Time.deltaTime * moveSpeed;

        if (Input.getButtonDown("Fire1"))
        {
            var rigidbody2D = GetComponent<Rigidbody2D>();
            rigidbody2D.AddForce(Vector2.up * jumpForce);
        }        
    }
}