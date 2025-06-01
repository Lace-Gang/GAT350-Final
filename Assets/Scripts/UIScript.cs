using UnityEngine;

public class UIScript : MonoBehaviour
{
    [SerializeField] GameObject Spawner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNormalClick()
    {
        Spawner.GetComponent<BallSpawnerManager>().ChangeBallType(BallSpawnerManager.BallType.Normal);
    }

    public void OnHeavyClick()
    {
        Spawner.GetComponent<BallSpawnerManager>().ChangeBallType(BallSpawnerManager.BallType.Heavy);
    }

    public void OnBouncyClick()
    {
        Spawner.GetComponent<BallSpawnerManager>().ChangeBallType(BallSpawnerManager.BallType.Bouncy);
    }
}
