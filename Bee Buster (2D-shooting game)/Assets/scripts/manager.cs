using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour

{
    public int score = 0;
    public int high_score = 0;
    public Text score_text;
    public Text high_score_text;
    // Start is called before the first frame update
    void Start()
    {
       LoadHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        //  score_text.text = "score: "+score.ToString();
         score_text.text = "score: " + score.ToString();
        if (score > high_score)
        {
            UpdateHighScore();
        }

    }
    public void save()
    {
        //  PlayerPrefs.SetInt("score", score);
        if (score > high_score)
        {
            high_score = score;
            PlayerPrefs.SetInt("high_score", high_score);
            high_score_text.text = "highest score: " + high_score.ToString();
        }
    }
    
     void UpdateHighScore()
    {
        high_score = score;
        high_score_text.text = "highest score: " + high_score.ToString();
        PlayerPrefs.SetInt("high_score", high_score);
    }

    void LoadHighScore()
    {
        high_score = PlayerPrefs.GetInt("high_score");
        high_score_text.text = "highest score: " + high_score.ToString();
    }
}
