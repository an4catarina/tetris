using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] Tetraminós;
    // Start is called before the first frame update
    void Start()
    {
        NovoTetramino();
    }

    public void NovoTetramino()
    {
        Instantiate(Tetraminós[Random.Range(0, Tetraminós.Length)], transform.position, Quaternion.identity);
    }
}