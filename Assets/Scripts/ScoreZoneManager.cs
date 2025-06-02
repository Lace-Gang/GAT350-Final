using UnityEngine;

public class ScoreZoneManager : MonoBehaviour
{
    [SerializeField] BoolData EndRound;
    [SerializeField] GameObject[] scoreZones;

    
    
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int random = Random.Range(0, scoreZones.Length);
        
        GameObject zone = scoreZones[random];
        
        zone.GetComponent<MeshRenderer>().enabled = true;
        zone.GetComponent<ScoreTrigger>().isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetThis()
    {
        for(int i = 0; i < scoreZones.Length; i++)
        {
            scoreZones[i].GetComponent<MeshRenderer>().enabled = false;
            scoreZones[i].GetComponent<ScoreTrigger>().isOn = false;
            scoreZones[i].GetComponent<ScoreTrigger>().timer = 0.0f;
        }
    
        int random = Random.Range(0, scoreZones.Length);
    
        GameObject zone = scoreZones[random];
    
        zone.GetComponent<MeshRenderer>().enabled = true;
        zone.GetComponent<ScoreTrigger>().isOn = true;
    }
}