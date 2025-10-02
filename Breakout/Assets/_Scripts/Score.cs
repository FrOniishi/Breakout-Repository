using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform transformHighScore;
    public Transform transformScore;
    public TMP_Text textHighScore;
    public TMP_Text textScore;

    public HighScore highScoreScriptableObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transformHighScore = GameObject.Find("HighScore").transform;
        transformScore = GameObject.Find("Score").transform;
        textHighScore = transformHighScore.GetComponent<TMP_Text>();
        textScore = transformScore.GetComponent<TMP_Text>();

        //if (PlayerPrefs.HasKey("HighScore"))
        //{
        //}

        highScoreScriptableObject.Load();   
        textHighScore.text = $"High Score: {highScoreScriptableObject.highScore}";
        highScoreScriptableObject.score = 0;
    }

    private void FixedUpdate()
    {
        highScoreScriptableObject.score += 50;
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = $"Score: {highScoreScriptableObject.score}";
        if (highScoreScriptableObject.score > highScoreScriptableObject.highScore)
        {
            highScoreScriptableObject.highScore = highScoreScriptableObject.score;
            textHighScore.text = $"High Score: {highScoreScriptableObject.highScore}";
            highScoreScriptableObject.Save();
            //PlayerPrefs.SetInt("HighScore", highScoreScriptableObject.score);
        }
    }
}
