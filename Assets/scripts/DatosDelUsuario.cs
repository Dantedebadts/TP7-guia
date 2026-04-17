using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombre = "";
    public int edad = 0;
    public float estatura = 0;
    public bool donanteDorganos = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombre + " y tengo " + edad + " años, mido " + estatura + " y es " + donanteDorganos + "(en español) dono organos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
