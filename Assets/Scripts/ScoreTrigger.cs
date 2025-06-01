using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField] IntData scoreData;

    [SerializeField] int scoreIncrease;

    GameObject ball = null;
    bool hasBall = false;
    float timer = 0;

    private void Update()
    {
        if(hasBall)
        {
            timer += Time.deltaTime;

            if (timer > 2.0f)
            {
                scoreData.Value += scoreIncrease;
                hasBall = false;
                //print("Detected");
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            ball = other.GetComponent<GameObject>();
            hasBall = true;
        }
    }
}
