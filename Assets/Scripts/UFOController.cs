using UnityEngine;

public class UFOController : MonoBehaviour
{
    public Pawn pawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Instantiate(pawn, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        MakeDecisions();
    }

    public void MakeDecisions()
    {
        UFOPawn ufoPawn = pawn.gameObject.GetComponent<UFOPawn>();
        ufoPawn.moveToPlayer();
    }
}
