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

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: code this later
}
