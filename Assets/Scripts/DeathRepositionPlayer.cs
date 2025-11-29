using UnityEngine;

public class DeathRepositionPlayer : DeathComponent
{
    public float XPos;
    public float YPos;
    public float ZPos;

    public override void Die()
    {
        //deincrement player lives
        GameManager.instance.playerLives -= 1;
        
        //reset the players position to ther coordinates
        transform.position = new Vector3(XPos, YPos, ZPos);

    }
}
