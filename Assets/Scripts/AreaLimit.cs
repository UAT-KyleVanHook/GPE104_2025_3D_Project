using UnityEngine;

public class AreaLimit : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //always get the current position
       //Vector3 currentPosition = transform.position;

        CheckCurrentPosition();

        
    }

    void CheckCurrentPosition()
    {
  

        //check get the current positions for x,y, and z.
        float currentX = this.transform.position.x;
        float currentY = this.transform.position.y;
        float currentZ = this.transform.position.z;



        //X,Y, and Z
        //compare the current x,y,& z to the x,y, & z bounds stored in the game manager from LevelData. 
        //make sure that current x,y, & z is not less than minX,minY, and minZ
        if ((currentX < GameManager.instance.minX) && (currentY < GameManager.instance.minY) && (currentZ < GameManager.instance.minZ))
        {
            this.transform.position = new Vector3(GameManager.instance.minX, GameManager.instance.minY, GameManager.instance.minZ);
        }


        //compare the current y & z to the y & z bounds stored in the game manager from LevelData. 
        //make sure that current x,y, & z is not more than maxX,maxY, and maxZ
        if ((currentX > GameManager.instance.maxX) && (currentY > GameManager.instance.maxY) && (currentZ > GameManager.instance.maxZ))
        {
            this.transform.position = new Vector3(GameManager.instance.maxX, GameManager.instance.maxY, GameManager.instance.maxZ);
        }





        //X and Y
        //compare the current x & y to the x & y bounds stored in the game manager from LevelData. 
        //make sure that current x & y is not less than minX and minY
        if ((currentX < GameManager.instance.minX) && (currentY < GameManager.instance.minY))
        {
            this.transform.position = new Vector3(GameManager.instance.minX, GameManager.instance.minY, currentZ);
        }


        //compare the current x & y to the x & y bounds stored in the game manager from LevelData. 
        //make sure that current x & y is not more than maxX and maxY
        if ((currentX > GameManager.instance.maxX) && (currentY > GameManager.instance.maxY))
        {
            this.transform.position = new Vector3(GameManager.instance.maxX, GameManager.instance.maxY, currentZ);
        }





        //X and -Y
        //compare the current x & y to the x & y bounds stored in the game manager from LevelData. 
        //make sure that current x is not less than minX and  y is not larger maxY
        if ((currentX < GameManager.instance.minX) && (currentY > GameManager.instance.maxY))
        {
            this.transform.position = new Vector3(GameManager.instance.minX, GameManager.instance.minY, currentZ);
        }


        //compare the current x & y to the x & y bounds stored in the game manager from LevelData. 
        //make sure that current x is not more than maxX and y is not less than minY
        if ((currentX > GameManager.instance.maxX) && (currentY < GameManager.instance.minY))
        {
            this.transform.position = new Vector3(GameManager.instance.maxX, GameManager.instance.minY, currentZ);
        }








        //X and Z
        //compare the current x & z to the x & z bounds stored in the game manager from LevelData. 
        //make sure that current x & z is not less than minX and minZ
        if ((currentX < GameManager.instance.minX) && (currentZ < GameManager.instance.minZ))
        {
            this.transform.position = new Vector3(GameManager.instance.minX, currentY, GameManager.instance.minZ);
        }


        //compare the current x & z to the x & z bounds stored in the game manager from LevelData. 
        //make sure that current x & z is not more than maxX and maxZ
        if ((currentX > GameManager.instance.maxX) && (currentZ > GameManager.instance.maxZ))
        {
            this.transform.position = new Vector3(GameManager.instance.maxX, currentY, GameManager.instance.maxZ);
        }








        //Y and Z
        //compare the current y & z to the y & z bounds stored in the game manager from LevelData. 
        //make sure that current y & z is not less than minY and minZ
        if ((currentY < GameManager.instance.minY) && (currentZ < GameManager.instance.minZ))
        {
            this.transform.position = new Vector3(currentX, GameManager.instance.minY, GameManager.instance.minZ);
        }


        //compare the current y & z to the y & z bounds stored in the game manager from LevelData. 
        //make sure that current y & z is not more than maxY and maxZ
        if ((currentY > GameManager.instance.maxY) && (currentZ > GameManager.instance.maxZ))
        {
            this.transform.position = new Vector3(currentX, GameManager.instance.maxY, GameManager.instance.maxZ);
        }












        //X
        //compare the current x to the x bound stored in the game manager from LevelData. 
        //make sure that current x is not less than minX
        if (currentX < GameManager.instance.minX)
        {
            this.transform.position = new Vector3(GameManager.instance.minX, currentY, currentZ);
        }

        //compare the current x to the x bound stored in the game manager from LevelData.
        //make sure that current x is not more than maxX
        if (currentX > GameManager.instance.maxX)
        {
            this.transform.position = new Vector3(GameManager.instance.maxX, currentY, currentZ);
        }



        //Y
        //compare the current y to the y bound stored in the game manager from LevelData. 
        //make sure that current y is not less than minY
        if (currentY < GameManager.instance.minY)
        {
            this.transform.position = new Vector3(currentX, GameManager.instance.minX, currentZ);
        }

        //compare the current x to the x bound stored in the game manager from LevelData.
        //make sure that current x is not more than maxX
        if (currentY > GameManager.instance.maxY)
        {
            this.transform.position = new Vector3(currentX, GameManager.instance.maxY, currentZ);
        }


        //Z
        //compare the current z to the z bound stored in the game manager from LevelData. 
        //make sure that current z is not less than minZ
        if (currentZ < GameManager.instance.minZ)
        {
            this.transform.position = new Vector3(currentX, currentY, GameManager.instance.minZ);
        }

        //compare the current z to the z bound stored in the game manager from LevelData.
        //make sure that current z is not more than maxZ
        if (currentZ > GameManager.instance.maxZ)
        {
            this.transform.position = new Vector3(currentX, currentY, GameManager.instance.maxZ);
        }




    }
}
