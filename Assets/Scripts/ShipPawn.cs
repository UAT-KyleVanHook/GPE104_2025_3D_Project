using UnityEngine;

public class ShipPawn : Pawn
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        //get health componnt
        health = GetComponent<HealthComponent>();

        //get death component
        death = GetComponent<DeathComponent>();
        
        rigidBody = GetComponent<Rigidbody>();

        shootComp = GetComponent<Shooter>();


    }

    // Update is called once per frame
    void Update()
    {

        // Enable gravity if the object's speed exceeds 3 units
        if (rigidBody.linearVelocity.magnitude > 3)
        {
            rigidBody.useGravity = true;

            //set gravity to -4 downward.
            Physics.gravity = new Vector3(0, -4.0F, 0);
        }
        else
        {
            rigidBody.useGravity = false;
        }



    }

    //move forward
    public override void MoveForward(float thrustSpeed)
    {

        Vector3 forwardVector = transform.forward * (thrustSpeed * Time.deltaTime);

        //forward thrust
        rigidBody.AddForce(forwardVector, ForceMode.Force);
        //some upward thrust to simulate gravity
        rigidBody.AddForce(transform.up * (thrustSpeed/2 * Time.deltaTime), ForceMode.Force);
    }

    //move backward
    public override void MoveBack(float thrustSpeed)
    {

        Vector3 forwardVector = -transform.forward * (thrustSpeed * Time.deltaTime);

        //reverse thrust
        rigidBody.AddForce(forwardVector, ForceMode.Force);
        //some upward thrust to simulate gravity
        rigidBody.AddForce(transform.up * (thrustSpeed/2 * Time.deltaTime), ForceMode.Force);
    }

    //(yaw) rotation
    public override void Rotate(float rotateValue)
    {

        //don't know why vector3.up wakes it rotate
        Vector3 rightVector = Vector3.up * (rotateValue * Time.deltaTime);

        transform.Rotate(rightVector, Space.Self);
        //rigidBody.AddTorque(rightVector, ForceMode.Force);

    }

    //change pitch
    public override void Pitch(float rotateValue)
    {

        Vector3 pitchtVector = Vector3.right * (rotateValue * Time.deltaTime);

        transform.Rotate(pitchtVector, Space.Self);
        //rigidBody.AddTorque(pitchtVector, ForceMode.Force);

    }
    //roll pawn
    public override void Roll(float rotateValue)
    {

        Vector3 rollVector = Vector3.forward * (rotateValue * Time.deltaTime);

        transform.Rotate(rollVector, Space.Self);
        //rigidBody.AddTorque(rollVector, ForceMode.Force);

    }

    //raise the pawn
    public override void Rise(float launchValue)
    {
        Vector3 riseVector = transform.up * (launchValue * Time.deltaTime);

        rigidBody.AddForce(riseVector, ForceMode.Force);
    }

}
