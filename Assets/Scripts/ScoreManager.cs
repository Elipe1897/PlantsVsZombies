using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;
    // varibles for the score and highscore
    public int score = 0;
    int highscore = 0;





    public void Awake()
    {
        instance = this; // it makes itself an instance

    }
    // Start is called before the first frame update
    public void Start()
    {
        // if the score points is higher than the highscore it replace the old highsore with the new highscore - Elias
        highscore = PlayerPrefs.GetInt("HIGHSCORE", 0);
        scoreText.text = " Score: " + score.ToString();
        highscoreText.text = "HIGHSCORE: " + highscore.ToString() ;

    }
    // Update is called once per frame
    public void Update()
    {

        if (highscore < score) // Looks if score is higher than highscore - Elias
        {
            PlayerPrefs.SetInt("HIGHSCORE", score);
        }
    }
    public void AddPoint(int point)// Adds the set points to points in score - Elias
    {
        score += point;
        scoreText.text = "| POINTS: " + score.ToString() + " |  ";
    }
}
   