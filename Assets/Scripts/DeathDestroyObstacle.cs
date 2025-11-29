using UnityEngine;

public class DeathDestroyObstacle : DeathComponent
{
    public GameObject projectileVFX;

    public override void Die()
    {
        AudioSource.PlayClipAtPoint(GameManager.instance.explosionSound, transform.position);

        //create a transform for the vfx
        Vector3 VFXPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        GameObject VFXClone = Instantiate(projectileVFX, VFXPosition, Quaternion.identity);

        //set timer to allow VFX to play and then destroy itself.
        Destroy(VFXClone, 1f);

        //destroy this object
        Destroy(gameObject);

    }
}
