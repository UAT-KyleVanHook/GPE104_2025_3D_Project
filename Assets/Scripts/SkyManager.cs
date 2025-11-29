using UnityEngine;

public class SkyManager : MonoBehaviour
{
    public float skySpeed;


    // Update is called once per frame
    void Update()
    {

        //Make the skybox rotate at the assigned speed, continously.
        //Don't use Time.DeltaTime, it doesn't work for some reason...
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skySpeed);
        
    }
}
