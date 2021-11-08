using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] Tetraminós;
    
    // Esse script fazem as peças spawnar no jogo;
    
    void Start()
    {
        NovoTetramino();
    }

    public void NovoTetramino()
    {
        Instantiate(Tetraminós[Random.Range(0, Tetraminós.Length)], transform.position, Quaternion.identity);
    }
}
