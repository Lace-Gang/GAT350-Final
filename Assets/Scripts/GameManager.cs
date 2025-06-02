using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject scoreZoneManager;
    [SerializeField] GameObject ballSpawnerManager;

    //things to change
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TMPro.TextMeshProUGUI scoreText;
    [SerializeField] TMPro.TextMeshProUGUI roundsText;
    //[SerializeField] TMPro.TextMeshPro scoreText;
    [SerializeField] GameObject[] endZones;

    //things to keep track of
    [SerializeField] IntData scoreData;
    [SerializeField] BoolData endRound;
    [SerializeField] BoolData fullReset;



    int score;
    int rounds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        rounds = 5;
        scoreData.Value = score;
        scoreText.text = "Score: " + score;
        roundsText.text = "Rounds: " + rounds;
    }

    // Update is called once per frame
    void Update()
    {
        if (fullReset)
        {
            FullReset();
            return;
        }
            

        if (score <= 0)
        {
            //
        }
        if (endRound.Value)
        {
            if(scoreData.Value != score)
            {
                //print("Detected");

                score = scoreData.Value;

                //+1 rounds
                rounds++;

                //change score text
                scoreText.text = "Score: " + score;
            }
            else
            {
                //-1 rounds
                rounds--;
            }
            //change rounds text
            roundsText.text = "Rounds: " + rounds;

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


    private void FullReset()
    {
        //reset score and number of rounds
        score = 0;
        scoreData.Value = 0;
        rounds = 5;

        //transition game pannels
        gameOverPanel.SetActive(false);
        mainPanel.SetActive(true);

        //reset screen text
        scoreText.text = "Score: " + score;
        roundsText.text = "Rounds: " + rounds;

        //reset all other game functionality managers
        scoreZoneManager.GetComponent<ScoreZoneManager>().ResetThis();
        ballSpawnerManager.GetComponent<BallSpawnerManager>().ResetThis();

        //set full reset data to false
        fullReset.Value = false;
    }
}
