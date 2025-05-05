using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositivoHastaNueve : MonoBehaviour
{

    public int numero;
    private bool esPositivo;
    private bool esMenorQueDiez;


    // Start is called before the first frame update
    void Start()
    {
        if(numero > 0)
        {
            esPositivo = true;
        }
        else
        {
            esPositivo = false;
        }
        if (numero < 10)
        {
            esMenorQueDiez = true;
        }
        else
        {
            esMenorQueDiez = false;
        }
        Debug.Log("Es " + esPositivo + " que el numero es positivo y es " + esMenorQueDiez + " que el numero es menor que diez");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
