using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] private float jumpForce = 1500f;

    private void OnTriggerEnter(Collider other)
    {
        // Classic null check.
        // var otherRigidbody = other.GetComponent<Rigidbody>();
        // if (otherRigidbody != null)
        //     otherRigidbody.AddForce(transform.up * jumpForce);

        //Null check with early return.
        // var otherRigidbody = other.GetComponent<Rigidbody>();
        // if (otherRigidbody == null)
        //     return;
        // otherRigidbody.AddForce(transform.up * jumpForce);

        //Null check using null propagation operator. Only runs AddForce() if Rigidbody is NOT null.
        other.GetComponent<Rigidbody>()?.AddForce(transform.up * jumpForce);

        //Only evaluates to true if the Rigidbody component is found, in which case TryGetComponent() returns true.
        // if (other.TryGetComponent(out Rigidbody rb))
        //     rb.AddForce(transform.up * jumpForce);
    }
}