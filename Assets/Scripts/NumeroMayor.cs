using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroMayor : MonoBehaviour
{
    public int numero1;
    public int numero2;

    void Start()
    {
        if (numero1 == numero2)
        {
            Debug.Log("Los números son iguales y son ambos: " + numero1);
        }
        else if (numero1 > numero2)
        {
            Debug.Log("El mayor de los dos números ingresados es " + numero1);
        }
        else
        {
            Debug.Log("El mayor de los dos números ingresados es " + numero2);
        }
    }
}
