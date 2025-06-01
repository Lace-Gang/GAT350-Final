using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //things to change
    [SerializeField] TMPro.TextMeshProUGUI scoreText;
    //[SerializeField] TMPro.TextMeshPro scoreText;

    //things to keep track of
    [SerializeField] IntData scoreData;


    int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        scoreData.Value = score;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreData.Value != score)
        {
            //print("Detected");

            score = scoreData.Value;
            //change score text
            scoreText.text = "Score: " + score;
        }
    }
}
