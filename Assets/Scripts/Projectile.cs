using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int moveSpeed;
    public int projectileDamage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        //If the projectile hasn't collided with an object with a health component or collider, then destroy after 5 secs after spawing.
        Destroy(this.gameObject, 5f);

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //immediatly start moving 
        transform.position = transform.position + ((transform.forward * moveSpeed) * Time.deltaTime);
    }


    public void OnCollisionEnter(Collision collision)
    {

        HealthComponent otherHealth = collision.gameObject.GetComponent<HealthComponent>();

        //check that the collided object has a health component. If true do damage.
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(projectileDamage);
        }

        //when colliding with another object, destroy this object.
        Destroy(this.gameObject);

    }

    public void OnTriggerEnter(Collider collision)
    {

        HealthComponent otherHealth = collision.gameObject.GetComponent<HealthComponent>();

        //check that the collided object has a health component. If true do damage.
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(projectileDamage);
        }

        //when colliding with another object, destroy this object.
        Destroy(this.gameObject);

    }

}
