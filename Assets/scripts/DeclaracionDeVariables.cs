using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DeclaracionDeVariables : MonoBehaviour
{

    public int numeroEntero = 1;
    public float numeroDecimal = 10.1f;    
    public string palabra = "string";
    bool booleano = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(numeroEntero);
        Debug.Log(palabra);
        Debug.Log(booleano);
        Debug.Log(numeroDecimal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
