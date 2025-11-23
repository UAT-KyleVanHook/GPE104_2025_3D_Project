using UnityEngine;

public class DamageOnCollisionUFO : MonoBehaviour
{
    public bool isInstaKill;
    public int damageDone;
    public float scoreAmount;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //add this DamageOnOverlap to the GameManager's List to keep count.
        //GameManager.instance.damageZones.Add(this);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        //Remove this DamageOnOverlap from the GameManager's List. It is dead and destroyed. Update the score.
        GameManager.instance.score += scoreAmount;
        //GameManager.instance.damageZones.Remove(this);


    }

    private void OnTriggerEnter(Collider collision)
    {

        //check if the collider is not another meteor
        //don't want metero's to explode on contact with one another.


        //get healthComponenet
        HealthComponent otherHealth = collision.gameObject.GetComponent<HealthComponent>();

        //check that the object has the health component
        if (otherHealth != null)
        {
            //check the that other object doesn't have the tag UFO
            if (otherHealth.tag != "UFO")
            {

                // if instakill is true, immeadiatly kill on trigger
                if (isInstaKill == true)
                {
                    //check that object has a death componenet
                    DeathComponent otherDeath = collision.gameObject.GetComponent<DeathComponent>();

                    if (otherDeath != null)
                    {
                        //play explosion sound at the point of an objects destruction.
                        //AudioSource.PlayClipAtPoint(GameManager.instance.explosionSound, transform.position, 1.0f);
                        otherHealth.Die();
                    }

                }

                //otherwise just take damage
                otherHealth.TakeDamage(damageDone);
            }
        }

    }
}
