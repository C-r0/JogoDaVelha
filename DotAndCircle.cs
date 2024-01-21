using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DotAndCircle : MonoBehaviour
{
    // Variaveis

    public Vector2 Pos1;
    public Vector2 Pos2;
    public Vector2 Pos3;
    public Vector2 Pos4;
    public Vector2 Pos5;
    public Vector2 Pos6;
    public Vector2 Pos7;
    public Vector2 Pos8;
    public Vector2 Pos9;
    public Vector2 ScaleX;
    public Vector2 ScaleO;
    public bool VezX;
    public GameObject Bola;
    public GameObject X;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextXO();
    }

    void TextXO() 
    {
        if (VezX == true)
        {
            Bola.SetActive(false);
            X.SetActive(true);
        }
        if (VezX == false)
        {
            Bola.SetActive(true);
            X.SetActive(false);
        }
    }
}
