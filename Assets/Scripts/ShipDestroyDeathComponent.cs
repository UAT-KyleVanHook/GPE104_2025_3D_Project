using UnityEngine;

public class ShipDestroyDeathComponent : DeathComponent
{

   public override void Die()
    {
        //destroy this object
        Destroy(gameObject);

    }

}
