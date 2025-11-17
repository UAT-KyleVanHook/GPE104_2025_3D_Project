using UnityEngine;

public class ShootProjectile : Shooter
{

    [Header("Projectile")]
    public GameObject projectileVFX;
    public GameObject projectilePrefab;
    public Transform firePoint;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {


    }

    public override void Shoot()
    {


        Debug.Log("Shooting Bullet!");

        GameObject VFXClone = Instantiate(projectileVFX, firePoint);

        //Instatiate a projectile prefab, using the position of an Empty transform object attached to the player prefab.
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        Destroy(VFXClone, 1f);

    }

}
