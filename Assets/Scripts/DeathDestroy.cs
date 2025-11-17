using UnityEngine;

public class DeathDestroy : DeathComponent
{


    public override void Die()
    {


        //destroy this object
        Destroy(gameObject);

    }

}
