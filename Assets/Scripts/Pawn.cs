using UnityEngine;

public abstract class Pawn : MonoBehaviour
{

    public HealthComponent health;
    public DeathComponent death;
    public Rigidbody rigidBody;

    [Header("Movement")]
    public float thrustSpeed;
    public float rotateValue;
    public float pitchValue;
    public float rollValue;
    public float launchValue;

    public abstract void MoveForward(float thrustSpeed);
    public abstract void MoveBack(float moveSpeed);
    public abstract void Rotate(float rotateValue);
    public abstract void Roll(float rollValue);
    public abstract void Pitch(float pitchValue);
    public abstract void Rise(float launchValue);

}
