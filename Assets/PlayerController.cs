using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// using System.Object;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField]
    GameObject bullet;
    float speed = 10;

    int jumpsLeft = 0;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue value) { // Control type: Vec2 -> (x, y)
        Vector2 input = value.Get<Vector2>();
        Debug.Log(input);
        Vector3 velocity = speed * (input.y * transform.forward + input.x * transform.right);
        velocity.y = rb.velocity.y;
        rb.velocity = velocity;
    }

    void OnFire() {
        Debug.Log("FIRED!");
        GameObject bulletInstance = Instantiate(bullet, transform.position + 0.5f * transform.forward, Quaternion.identity);
        Rigidbody bulletRigidbody = bulletInstance.GetComponent<Rigidbody>();

        bulletRigidbody.AddForce(speed * 10f * transform.forward);
    }

    void OnJump() {
        Debug.Log("JUMP!");
        if (jumpsLeft>0) {
            // Debug.Log((100 * Vector3.up).ToString());
            rb.AddForce(400 * Vector3.up);
            jumpsLeft--;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Ground"))
            jumpsLeft = 2;
    }

    private void OnCollisionExit(Collision other) {
        if (other.gameObject.CompareTag("Ground"))
            jumpsLeft = 1;
    }
}
