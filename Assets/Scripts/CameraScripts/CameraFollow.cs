using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target; //Declaring variables
    Vector3 offset;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        offset = transform.position - Target.position; //moves camera to where player is without rotating camera
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = Target.position + offset;  // same as on start but as a lateupdate with +offset
    }
}