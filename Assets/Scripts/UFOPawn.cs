using UnityEngine;

public class UFOPawn : Pawn
{

    Pawn playerPawn;

    [Header("Movement Speed - for UFO")]
    public float movementSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        playerPawn = GameManager.instance.playerPawn;

    }

    // Update is called once per frame
    void Update()
    {

        playerPawn = GameManager.instance.playerPawn;

    }

    public void moveToPlayer()
    {
        //if player pawn is true, move towards the position of the pawn
        if (playerPawn != null)
        {

            this.transform.position = Vector3.MoveTowards(this.transform.position, playerPawn.transform.position, movementSpeed * Time.deltaTime);

        }
    }



    public override void MoveForward(float thrustSpeed)
    {

    }

    public override void MoveBack(float moveSpeed)
    {

    }

    public override void Rotate(float rotateValue)
    {

    }

    public override void Roll(float rollValue)
    {

    }

    public override void Pitch(float pitchValue)
    {

    }

    public override void Rise(float launchValue)
    {

    }
}
