using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTimeIcone : MonoBehaviour
{

    public float sped;
    private float x;
    private float contador;

    public GameObject Player;


    void Start()
    {
        Player = GameObject.Find("Player") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        contador = Random.Range(1, 100);
        if (contador > 40)
        {
            sped -= 0.04f;
        }

        x = transform.position.x;

        x += sped * Time.deltaTime;

        transform.position = new Vector3(x, transform.position.y, transform.position.y);


        if (x <= -12)
        {
            Destroy(transform.gameObject);
        }

    }
}
