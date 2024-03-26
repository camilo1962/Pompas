using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    AudioSource gameAudio;
    public int Score, record;
    public Text ScoreText, RecordText;


    public int ball2  = 0;
    public int ball1 = 0;
    public static GameController instance;

    

    void Awake()
    {

        // give reference to created object.
        instance = this;

    }
    void Start()
    {
        gameAudio = GetComponent<AudioSource>();
        gameAudio.loop = true;
        gameAudio.Play();

        Score = 0;
        ScoreText.text = "Puntos:" + Score;
        RecordText.text = PlayerPrefs.GetInt("record").ToString();
    }

    // Update is called once per frame
    

    public void updateScore(int val)
    {
        Score += val;
        ScoreText.text = "Puntos:" + Score;

       
    }
    void Update()
    {
        if (Score > PlayerPrefs.GetInt("record"))
        {
            record = Score;
            PlayerPrefs.SetInt("record", Score);
            RecordText.text = "Record: " + PlayerPrefs.GetInt("record").ToString();
            RecordText.text = "Record: " + record;
        }
    }


}
