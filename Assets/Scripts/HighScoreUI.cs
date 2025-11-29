using TMPro;
using UnityEngine;

public class HighScoreUI : MonoBehaviour
{
    public TMP_Text highScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HighScoreUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        HighScoreUpdate();
    }

    public void HighScoreUpdate()
    {

        //check if there is a playerPref with the tag HighScore

            //get the HighScore and assign to text
            highScoreText.text =  "HighScore: " + PlayerPrefs.GetFloat("HighScore").ToString();

        

    }
}
