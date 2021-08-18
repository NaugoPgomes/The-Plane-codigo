using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y : MonoBehaviour
{
    public Rigidbody2D PlayerRigidbody;
    public int Force;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerRigidbody.AddForce(new Vector2(0, Force));
        }
    }
}
