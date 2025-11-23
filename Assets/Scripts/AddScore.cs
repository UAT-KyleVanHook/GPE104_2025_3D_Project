using UnityEngine;

public class AddScore : MonoBehaviour
{

    public float scoreAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
