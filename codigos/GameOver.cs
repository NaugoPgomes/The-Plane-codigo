using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public UnityEngine.UI.Text score;
    public UnityEngine.UI.Text record;

    void Start()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        record.text = PlayerPrefs.GetInt("record").ToString();
    }

}
