using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public float rateSpawn;
    public GameObject bombPrefab;
    private float currentTime;

    private int position;
    private float y;

    public float posA;
    public float posB;


    void Start()
    {
        currentTime = 0;
    }


    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn)
        {
            currentTime = 0;
            position = Random.Range(1, 100);
            if (position > 50)
            {
                y = posA;
                rateSpawn -= 0.02f;

            }
            else
            {
                y = posB;
            }
            if (rateSpawn <= 1.45f)
            {
                rateSpawn = 1.45f;
            }

            GameObject tempPrefab = Instantiate(bombPrefab) as GameObject;
            tempPrefab.transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }


    }
}