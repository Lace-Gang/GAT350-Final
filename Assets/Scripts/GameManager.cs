using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject scoreZoneManager;
    [SerializeField] GameObject ballSpawnerManager;

    //things to change
    [SerializeField] TMPro.TextMeshProUGUI scoreText;
    //[SerializeField] TMPro.TextMeshPro scoreText;
    [SerializeField] GameObject[] endZones;

    //things to keep track of
    [SerializeField] IntData scoreData;
    [SerializeField] BoolData endRound;


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
        if(endRound.Value)
        {
            if(scoreData.Value != score)
            {
                //print("Detected");

                score = scoreData.Value;
                //change score text
                scoreText.text = "Score: " + score;
            }
            //if not

            //reset various game components
            scoreZoneManager.GetComponent<ScoreZoneManager>().ResetThis();
            ballSpawnerManager.GetComponent<BallSpawnerManager>().ResetThis();

            foreach(GameObject zone in endZones)
            {
                zone.GetComponent<ScoreTrigger>().timer = 0.0f;
            }

            //return endround to false
            endRound.Value = false;
        }

    }
}
