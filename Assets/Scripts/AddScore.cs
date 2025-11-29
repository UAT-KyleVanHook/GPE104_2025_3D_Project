using UnityEngine;

public class AddScore : MonoBehaviour
{

    public float scoreAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.instance.astronautsList.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy()
    {
        //Remove this DamageOnOverlap from the GameManager's List. It is dead and destroyed.
        GameManager.instance.astronautsList.Remove(this);


    }

    public void OnCollisionEnter(Collision other)
    {

        ShipPawn collidedObject = other.gameObject.GetComponent<ShipPawn>();

       if (collidedObject != null)
        {

            AudioSource.PlayClipAtPoint(GameManager.instance.pickupSound, transform.position);

            //increment score
            GameManager.instance.score += scoreAmount;

            //destroy object after collection
            Destroy(gameObject);
        }

        

    }
}
