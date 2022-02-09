using UnityEngine;

public class WalkController : MonoBehaviour
{
    //TODO Remove MovementApplier and return to applying velocities and forces directly in the walk and jump scripts?
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;

    [SerializeField] private GroundChecker groundChecker;

    // [SerializeField] private float walkSpeed = 5f;
    // [SerializeField] private float chargingWalkSpeedFactor = 0.5f;
    [SerializeField] private WalkSpeedSO walkSpeedSo;

    private void Update()
    {
        HandleWalking();
    }

    private void HandleWalking()
    {
        //Slower move speed while charging a jump.
        var currentMoveSpeed = walkSpeedSo.WalkSpeed;
        if (commandContainer.jumpCommand && groundChecker.IsGrounded)
            currentMoveSpeed *= walkSpeedSo.ChargingWalkSpeedFactor;

        myRigidbody.velocity = new Vector3(commandContainer.walkCommand * currentMoveSpeed, myRigidbody.velocity.y, 0);
    }
}