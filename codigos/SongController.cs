using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongController : MonoBehaviour
{

    private bool Song = true;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SongVolume()
    {
        Song = !Song;
        if(Song == true)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}
