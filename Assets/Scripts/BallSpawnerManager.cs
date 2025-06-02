using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerManager : MonoBehaviour
{
    //ball enum
    public enum BallType { Normal, Heavy, Bouncy }

    [SerializeField] GameObject[] BallSpawners;

    [SerializeField] GameObject normalBall;
    [SerializeField] GameObject heavyBall;
    [SerializeField] GameObject bouncyBall;

    [SerializeField] Material normalMaterial;
    [SerializeField] Material heavyMaterial;
    [SerializeField] Material bouncyMaterial;

    public BallType ballType = BallType.Normal;
    //private List<GameObject> ballPool;

    private GameObject ball;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(GameObject ballSpawn in BallSpawners)
        {
            ballSpawn.GetComponent<MeshRenderer>().material = normalMaterial;
        }
    }

    // Update is called once per frame
    void Update()
    {
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

                        //GameObject ball = null;
                        Vector3 newTransform = BallSpawners[i].GetComponent<Transform>().position;
                        newTransform.x += 0.5f;
                        newTransform.y -= 0.25f;

                        switch (ballType)
                        {
                            case BallType.Normal:
                                //ball = Instantiate(normalBall, BallSpawners[i].GetComponent<Transform>().position, BallSpawners[i].GetComponent<Transform>().rotation);
                                ball = Instantiate(normalBall, newTransform, BallSpawners[i].GetComponent<Transform>().rotation);
                                break;
                            case BallType.Heavy:
                                //ball = Instantiate(heavyBall, BallSpawners[i].GetComponent<Transform>().position, BallSpawners[i].GetComponent<Transform>().rotation);
                                ball = Instantiate(heavyBall, newTransform, BallSpawners[i].GetComponent<Transform>().rotation);

                                break;
                            case BallType.Bouncy:
                                //ball = Instantiate(bouncyBall, BallSpawners[i].GetComponent<Transform>().position, BallSpawners[i].GetComponent<Transform>().rotation);
                                ball = Instantiate(bouncyBall, newTransform, BallSpawners[i].GetComponent<Transform>().rotation);

                                break;
                            default:
                                break;
                        }


                    }
                }
            }

        }
    }


    public void ChangeBallType(BallType type)
    {
        ballType = type;
        switch (ballType)
        {
            case BallType.Normal:
                foreach (GameObject ballSpawn in BallSpawners)
                {              
                    ballSpawn.GetComponent<MeshRenderer>().material = normalMaterial;
                }
                break;
            case BallType.Heavy:
                foreach (GameObject ballSpawn in BallSpawners)
                {
                    ballSpawn.GetComponent<MeshRenderer>().material = heavyMaterial;
                }
                break;
            case BallType.Bouncy:
                foreach (GameObject ballSpawn in BallSpawners)
                {
                    ballSpawn.GetComponent<MeshRenderer>().material = bouncyMaterial;
                }
                break;
            default:
                break;
        }

    }


    public void ResetThis()
    {
        //foreach (GameObject ball in ballPool)
        //{
        //    GameObject.Destroy(ball);
        //}

        GameObject.Destroy(ball);
    }
}
