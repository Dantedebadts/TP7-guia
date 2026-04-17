using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cálculos_personalizados : MonoBehaviour
{
    public float num1 = 0f;
    public float num2 = 0f;
    public float resultado = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
       resultado = num1 + num2;
       Debug.Log("el resultado de la suma es " + resultado);
       resultado = num1 - num2;
       Debug.Log("el resultado de la resta es " + resultado);
       resultado = num1 * num2;
       Debug.Log("el resultado de la multiplicacion es " + resultado);
       resultado = num1 / num2;
       Debug.Log("el resultado de la division es " + resultado);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
