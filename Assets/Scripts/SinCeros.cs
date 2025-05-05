using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinCeros : MonoBehaviour
{

    public float numero1;
    public float numero2;

    // Start is called before the first frame update
    void Start()
    {
        if (numero2 == 0)
        {
            Debug.Log("No se puede dividir por cero");
        }
        else
        {
            Debug.Log("La division es: " + numero1 / numero2);
        }
    }
}
