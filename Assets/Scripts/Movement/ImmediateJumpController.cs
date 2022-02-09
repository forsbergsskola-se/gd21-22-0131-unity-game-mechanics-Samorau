using UnityEngine;

public class ImmediateJumpController : MonoBehaviour
{
    //TODO Remove MovementApplier and return to applying velocities and forces directly in the walk and jump scripts?
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private float jumpForce = 500f;

    private void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        //Apply jump force
        //Preferably interact with physics in FixedUpdate() 
        if (commandContainer.jumpCommandDown && groundChecker.IsGrounded)
            myRigidbody.AddForce(Vector3.up * jumpForce);
    }
}