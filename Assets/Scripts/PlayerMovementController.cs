using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical);

        Debug.Log(movement);
    }
}