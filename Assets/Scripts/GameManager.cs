using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Singleton variable
    public static GameManager instance;

    public List<AddScore> astronautsList;
    //public int enemyCount;

    //player variables
    public Pawn playerPawn;
    //public bool isPlayerDead = false;

    //was used to determine if player is dead, not needed now.
    //bool bPlayDeathMessage = true;

    //score for game
    [Header("Score")]
    public float score;

    [Header("Lives")]
    public float playerLives;


    //timer variables
    //[Header("Timer")]
    //public float TimeRemaining;
    //public float MaxTime;

    [Header("SoundClips")]
    public AudioClip shootingSound;
    public AudioClip explosionSound;
    public AudioClip pickupSound;
    public AudioClip shipHurtSounds;
    public AudioClip backgroundMusicClip;

    [Header("Audio Sources")]
    public AudioSource backgroundMusicSource;

    //screen warp boundry
    [Header("Game Bounds")]
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float maxZ;
    public float minZ;

    //checks that the timer hasn't run out.
    //public bool bTimeRanOut = false;

    //private float currentTime = 1;

    //this is  the only GameManager that can exist. We want this to happen before start
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        //Create new List to store AddScore for astronauts (I should have done this differently, next time)
        astronautsList = new List<AddScore>();

        //backgroundmusic
        backgroundMusicSource.clip = backgroundMusicClip;
        backgroundMusicSource.Play();





    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get remaining at the start of the game.
        //GetRemainingEnemies();
    }


    // Update is called once per frame
    void Update()
    {

        Debug.Log("Astronauts alive: " + astronautsList.Count);

        //check if the playerlives is zero. Player pawn is never destroyed
        if (playerLives <= 0)
        {
            GameOver();
        }

        if(astronautsList.Count == 0)
        {
            WinGame();
        }

    }

    //go to game over screen
    void GameOver()
    {

        //check if there is a playerPref with the tag HighScore

            if (score > PlayerPrefs.GetFloat("HighScore"))
            {

                //set current score to playerPrefs HighScore
                PlayerPrefs.SetFloat("HighScore", score);

            }
        


        SceneManager.LoadScene("GameOver");

    }

    //go to the win screen
    void WinGame()
    {

        //check if there is a playerPref with the tag HighScore

            if (score > PlayerPrefs.GetFloat("HighScore"))
            {

                //set current score to playerPrefs HighScore
                PlayerPrefs.SetFloat("HighScore", score);

            }


        

        SceneManager.LoadScene("WinScene");

    }
}
