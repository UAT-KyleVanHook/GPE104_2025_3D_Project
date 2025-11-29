using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    float UIScore;

    //lives text and image
    //public Image TimerImage;
    public TMP_Text livesText;
    float currentPlayerLives;

    //bool bTimeRanOut = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        //set initial texts
        scoreText.text = "Score:";
        livesText.text = "Lives x";

        //get the player lives from the game manager
        currentPlayerLives = GameManager.instance.playerLives;

    }

    // Update is called once per frame
    void Update()
    {

        UpdateScoreText();

        UpdateLivesCount();


    }
    void UpdateScoreText()
    {

        UIScore = GameManager.instance.score;

        scoreText.text = "Score: " + UIScore;

    }

    void UpdateLivesCount()
    {
        currentPlayerLives = GameManager.instance.playerLives;

        //Debug.Log("CurrentPlayerLives: " + currentPlayerLives);

        livesText.text = "Lives x " + currentPlayerLives;
    }

}
