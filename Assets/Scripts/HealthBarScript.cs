using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    //health bar items
    public Slider healthBarSlider;
    public TextMeshProUGUI healthBarText;

    public GameObject pawn;

    public int currentHealth;
    public int maxHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get the values of the pawn
        HealthComponent pawnHealthComp = pawn.GetComponent<HealthComponent>();

        if (pawnHealthComp != null)
        {

            currentHealth = pawnHealthComp.currentHealth;
            maxHealth = pawnHealthComp.maxHealth;

        }

    }

    // Update is called once per frame
    void Update()
    {
        //get the values of the pawn
        HealthComponent pawnHealthComp = pawn.GetComponent<HealthComponent>();

        if (pawnHealthComp != null)
        {

            currentHealth = pawnHealthComp.currentHealth;
            maxHealth = pawnHealthComp.maxHealth;

        }

        //update values on slider and text
        healthBarSlider.value = currentHealth;
        healthBarSlider.maxValue = maxHealth;

        healthBarText.text = currentHealth.ToString() + "/" + maxHealth.ToString();
    }
}
