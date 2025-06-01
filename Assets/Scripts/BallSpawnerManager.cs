using UnityEngine;

public class BallSpawnerManager : MonoBehaviour
{
    [SerializeField] GameObject[] BallSpawners;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        //print("hello 1");
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                for (int i = 0; i < BallSpawners.Length; ++i)
                {
                    if(hit.rigidbody == BallSpawners[i].GetComponent<Rigidbody>())
                    {
                        print("Clicked");
                    }
                }
            }

            //hit.rigidbody


                //if (hit.transform.position == transform.position)
                //{
                //    print("hello");
                //    Instantiate(swappedInto, transform.position, transform.rotation);
                //    Destroy(gameObject);
                //}
        }
    }
}
