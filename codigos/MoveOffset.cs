using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour
{

    public float sped;
    private Material materialAtual;
    private float escalaMovimento;


    void Start()
    {
        materialAtual = GetComponent<Renderer>().material;
    }

    void Update()
    {
        escalaMovimento += 0.02f;
        materialAtual.SetTextureOffset("_MainTex", new Vector2(escalaMovimento * sped, 0));
    }

}
