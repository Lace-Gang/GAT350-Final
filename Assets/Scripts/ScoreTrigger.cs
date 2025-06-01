using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField] IntData scoreData;

    [SerializeField] int scoreIncrease;

    bool hasBall = false;
    public bool isOn = false;

    float timer = 0;

    private void Update()
    {
        if(hasBall)
        {
            timer += Time.deltaTime;

            if (timer > 2.0f)
            {
                if(isOn) scoreData.Value += scoreIncrease;
                hasBall = false;
                //print("Detected");
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            hasBall = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            hasBall = false;
        }
    }
}
