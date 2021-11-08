using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour
{
//O código contido aqui, está linkado na grade de fundo. O objetivo dele é definir o espaço no qual as peças podem se mover.

 public static int altura = 20;
 public static int largura = 10;

public bool InteriorGrid(Vector2 posicao)
{
    return ((int)posicao.x > 0 && (int)posicao.x <= largura && (int)posicao.y > 0);
}

public Vector2 arredonda(Vector2 NA)
{
    return new Vector2(Mathf.Round(NA.x), Mathf.Round(NA.y));
}
}
