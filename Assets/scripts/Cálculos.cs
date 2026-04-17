using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cálculos : MonoBehaviour
{
    public int num1 = 0;
    public int num2 = 0;
    public int resultado = 0;
    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 + num2;
        Debug.Log("El resultado de " + num1 + " + " + num2 + " es " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
