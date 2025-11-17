using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton variable
    public static GameManager instance;

    //public List<DamageOnOverlap> damageZones;
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
    public AudioClip metalSound;
    public AudioClip backgroundMusicClip;

    [Header("Audio Sources")]
    public AudioSource backgroundMusicSource;

    //screen warp boundry
    [Header("Bounding Box")]
    public float maxX;
    public float maxY;
    public float maxZ;

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

        //Create new List to store DamageOnOVerlap's
        //damageZones = new List<DamageOnOverlap>();

        //backgroundmusic
        //backgroundMusicSource.clip = backgroundMusicClip;
        //backgroundMusicSource.Play();





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

        Debug.Log(score);

    }
}
