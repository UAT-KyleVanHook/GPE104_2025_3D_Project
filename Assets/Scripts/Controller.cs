using UnityEngine;

public abstract class Controller : MonoBehaviour
{

    public Pawn pawn;

    public Camera cam;

    public abstract void MakeDecisions();

}
