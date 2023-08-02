using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Points : MonoBehaviour
{
    public Text ScoreText;
    public Text EndText;
    public Text SubmitText;
    public int Score;
    private string input;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        ScoreText.text = "SCORE : " + Score;
        EndText.text = "SCORE : " + Score;
        SubmitText.text = "SCORE : " + Score;
    }

    private void OnTriggerEnter2D(Collider2D point)
    {
        if(point.tag == "point_trash")
        {
            Score += 100;
            Destroy(point.gameObject);
            ScoreText.text = "SCORE : " + Score;
            EndText.text = "SCORE : " + Score;
            SubmitText.text = "SCORE : " + Score;
        }
        if(point.tag == "point_fish")
        {
            Score -= 100;
            Destroy(point.gameObject);
            ScoreText.text = "SCORE : " + Score;
            EndText.text = "SCORE : " + Score;
            SubmitText.text = "SCORE : " + Score;
        }
    }

    public void getInput(string s)
    {
        input = s;
        Debug.Log(input);
    }

    public void SendScore()
    {
        HighScores.UploadScore(input, Score);
        SceneManager.LoadScene(0);
    }
}
