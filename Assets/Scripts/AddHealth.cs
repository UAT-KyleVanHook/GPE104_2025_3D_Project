using UnityEngine;

public class AddHealth : MonoBehaviour
{
    public int healAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {

        //check if the collider is not another meteor
        //don't want metero's to explode on contact with one another.


        //get healthComponenet
        HealthComponent otherHealth = other.gameObject.GetComponent<HealthComponent>();

        //check that the object has the health component
        if (otherHealth != null)
        {
            if (otherHealth.currentHealth < otherHealth.maxHealth)
            {
                AudioSource.PlayClipAtPoint(GameManager.instance.pickupSound, transform.position);

                //add health amount
                otherHealth.Heal(healAmount);

                //destroy this object
                Destroy(gameObject);
            }
        }

    }
}
