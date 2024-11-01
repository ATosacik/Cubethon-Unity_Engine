using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 100f;
    public float yLimit = -2f;

    void FixedUpdate() {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("a") ) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("d") ) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( rb.position.y <= yLimit ) {
            FindObjectOfType<GameManager>().restartDelay = 0.5f;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
