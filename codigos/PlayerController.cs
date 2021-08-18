using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class PlayerController : MonoBehaviour
{
    //colisor
    public Transform colisor;

    // pontuação 
    public UnityEngine.UI.Text txtScore;
    public static int score;

    // ADS
    private int number;

    // Tempo
    public int Time;
    public Text TimeTXT;


    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("score", score);
        Advertisement.Initialize("*******");
        StartCoroutine("TimeFase");
    }

    void Update()
    {
        txtScore.text = score.ToString();
    }

    IEnumerator TimeFase()
    {
        TimeTXT.text = Time.ToString();
        yield return new WaitForSeconds(1);

        Time -= 1;

        if(Time > 0)
        {
            StartCoroutine("TimeFase");
        }
        else
        {
            PlayerPrefs.SetInt("score", score);

            if (score > PlayerPrefs.GetInt("record"))
            {
                PlayerPrefs.SetInt("record", score);

            }

            number = Random.Range(1, 100);

            if (number <= 40)
            {
                Advertisement.Show("video");
            }

            SceneManager.LoadScene("GameOver");
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Time"))
        {
            Time += 10;
            TimeTXT.text = Time.ToString();
            Destroy(col.gameObject);
        }

    }


    void OnCollisionEnter2D()
    {
        PlayerPrefs.SetInt("score", score);
        if (score > PlayerPrefs.GetInt("record"))
        {
            PlayerPrefs.SetInt("record", score);

        }

        number = Random.Range(1, 100);

        if (number <= 40)
        {
            Advertisement.Show("video");
        }

        SceneManager.LoadScene("GameOver");

    }


}
