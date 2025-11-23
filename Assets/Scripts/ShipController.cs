using UnityEngine;

public class ShipController : Controller
{

    public Camera cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //cam = GetComponent<Camera>();
        //cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        MakeDecisions();
    }

    public override void MakeDecisions()
    {
        //move forward
        if (Input.GetKey(KeyCode.W))
        {

            //Tell pawn to Move Forward
            pawn.MoveForward(pawn.thrustSpeed);

        }

        //move backwards
        if (Input.GetKey(KeyCode.D))
        {

            //Tell pawn to Move back
            pawn.MoveBack(pawn.thrustSpeed);

        }

        //rotate left (yaw)
        if (Input.GetKey(KeyCode.A))
        {

            //Tell pawn to rotate left
            pawn.Rotate(pawn.rotateValue * -1);

        }

        //rotate right (yaw)
        if (Input.GetKey(KeyCode.S))
        {

            //Tell pawn to Move rotate right
            pawn.Rotate(pawn.rotateValue);

        }

        //pitch up
        if (Input.GetKey(KeyCode.Z))
        {

            //Tell pawn to Move rotate right
            pawn.Pitch(pawn.pitchValue * -1);

        }

        //pitch down
        if (Input.GetKey(KeyCode.X))
        {

            //Tell pawn to Move rotate right
            pawn.Pitch(pawn.pitchValue);

        }

        //Roll Left
        if (Input.GetKey(KeyCode.Q))
        {

            //Tell pawn to Move rotate right
            pawn.Roll(pawn.rollValue);

        }

        //Roll Right
        if (Input.GetKey(KeyCode.E))
        {

            //Tell pawn to Move rotate right
            pawn.Roll(pawn.rollValue * -1);

        }

        //raise pawn
        if (Input.GetKey(KeyCode.R))
        {

            //Tell pawn to Move rotate right
            pawn.Rise(pawn.launchValue);

        }

        //shoot projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pawn.shootComp.Shoot();

        }

        //decrease the camera offset
        if (Input.GetKeyDown(KeyCode.O))
        {
           FollowPlayer camFollow = cam.GetComponent<FollowPlayer>();
            camFollow.decreaseOffset();
        }

        //increase the camera offset
        if (Input.GetKeyDown(KeyCode.L))
        {
            FollowPlayer camFollow = cam.GetComponent<FollowPlayer>();
            camFollow.increaseOffset();
        }

    }
}
