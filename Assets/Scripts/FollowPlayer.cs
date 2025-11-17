using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;


public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Transform lookPoint;

    public float rotationSpeed;
    public float moveSpeed;

    public float offsetMin;
    public float offsetMax;

    //public float cameraOffsetX;
    public float cameraOffsetY;
    public float cameraOffsetZ;

    private Vector3 cameraOffset;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraOffset = new Vector3(transform.position.x, cameraOffsetY, cameraOffsetZ);

        //check if the starting camera offset is larger or smaller than tha min or max.
        if (cameraOffsetZ > offsetMin || cameraOffsetZ < offsetMax)
        {
            cameraOffsetZ = -5f;
        }

    }

    // Update is called once per frame
    void Update()
    {

        //is in ShipController now.
        //decreaseOffset();

        //increaseOffset();


        //update the camera's position
        transform.position = player.position + player.rotation * cameraOffset;

        //Update the camera's rotation to follow the players rotation
        transform.rotation = player.rotation;

        //always look at this point
        transform.LookAt(lookPoint);

    }

    public void decreaseOffset()
    {

        //decrease offset length, towards ship.
       // if (Input.GetKeyDown(KeyCode.O))
        //{
            if (cameraOffset.z != offsetMin)
            {
                cameraOffset.z += 1;
                Debug.Log(cameraOffsetZ);

                //cameraOffset = new Vector3(transform.position.x, transcameraOffsetY, cameraOffsetZ);


            }

        //}

    }

    public void increaseOffset()
    {
        //increase the offset length away from ship
        //if (Input.GetKeyDown(KeyCode.L))
       // {
            if (cameraOffset.z != offsetMax)
            {
                cameraOffset.z += -1;
                Debug.Log(cameraOffsetZ);

                //cameraOffset = new Vector3(transform.position.x, cameraOffsetY, cameraOffsetZ);

            }

       // }

    }

}
