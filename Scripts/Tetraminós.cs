using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetraminós : MonoBehaviour
{
    public Vector3 rotacao;
    private float previousTime;
    public float queda = 0.8f;
    public static int altura = 20;
    public static int largura = 10;
    private static Transform[,] grid = new Transform[largura, altura];
    
    void Start()
    {
        
    }

    void Update()
    {
        //movimentação das peças
         if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            if(!MovimentoValido())
                transform.position -= new Vector3(1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            if(!MovimentoValido())
                transform.position -= new Vector3(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.RotateAround(transform.TransformPoint(rotacao), new Vector3(0,0,1), 90);
            if (!MovimentoValido())
                transform.RotateAround(transform.TransformPoint(rotacao), new Vector3(0, 0, 1), -90);
        }
        if(Time.time - previousTime > (Input.GetKey(KeyCode.DownArrow) ? queda / 15 : queda))
        {
            transform.position += new Vector3(0, -1, 0);
            if(!MovimentoValido())
            {
                transform.position -= new Vector3(0, -1, 0);
                AddToGrid();

                apagaLinha();

                this.enabled = false;
                FindObjectOfType<Spawn>().NovoTetramino();
            }
        previousTime = Time.time;
        }
    }

void AddToGrid()
{
    foreach(Transform children in transform)
    {
        int roundedX = Mathf.RoundToInt(children.transform.position.x);
        int roundedY = Mathf.RoundToInt(children.transform.position.y);

        grid[roundedX, roundedY] = children;
    }
}


public bool linhaCheia(int A)
    {
        for (int B = 0; B < largura; B++)
        {
            if (grid[B,A] == null)
            {
                return false;
            }
        }
        return true;
    }

    public void deletaQuadrado(int A)
    {
        for (int B = 0; B < largura; B++)
        {
            Destroy(grid[B, A].gameObject);

            grid[B, A] = null;
        }
    }

    public void moveLinhaBaixo(int A)
    {
        for (int B = 0; B < largura; B++)
        {
            if(grid[B,A] != null)
            {
                grid[B, A - 1] = grid[B, A];
                grid[B, A] = null;
                grid[B, A - 1].position += new Vector3(0, -1, 0);
            }
        }
    }

    public void moveTodasLinhasBaixo (int A)
    {
        for (int i = A; i < altura; i++)
        {
            moveLinhaBaixo(i);
        }
    }

    public void apagaLinha()
    {
        for (int A = 0; A < altura; A++)
        {
            if (linhaCheia(A)){
                deletaQuadrado(A);
                moveTodasLinhasBaixo(A + 1);
                A--;
            }
        }
    }
bool MovimentoValido()
{
    foreach (Transform children in transform)
    {
        int roundedX = Mathf.RoundToInt(children.transform.position.x);
        int roundedY = Mathf.RoundToInt(children.transform.position.y);

        if (roundedX < 0 || roundedX > largura || roundedY < 0 || roundedY >= altura)
        {
            return false;
        }
        
        if (grid[roundedX, roundedY] !=null)
            return false;
    }
    return true;
    
}
}
