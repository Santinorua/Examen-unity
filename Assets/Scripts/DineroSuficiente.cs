using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroSuficiente : MonoBehaviour
{

    public float dinero;
    public float precio1;
    public float precio2;
    private float suma;

    // Start is called before the first frame update
    void Start()
    {
        suma = precio1 + precio2;

        if (dinero > suma)
        {
            Debug.Log("Sobra dinero");
        }
        else if (dinero == suma)
        {
            Debug.Log("Alcanza justo el dinero");
        }
        else
        {
            Debug.Log("No hay suficiente dinero");
        }
    }
}
