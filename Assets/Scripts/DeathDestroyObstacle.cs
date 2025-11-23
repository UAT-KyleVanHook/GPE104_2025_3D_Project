using UnityEngine;

public class DeathDestroyObstacle : DeathComponent
{
    public override void Die()
    {
        AudioSource.PlayClipAtPoint(GameManager.instance.explosionSound, transform.position);

        //destroy this object
        Destroy(gameObject);

    }
}
