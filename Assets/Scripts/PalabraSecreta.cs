using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalabraSecreta : MonoBehaviour
{

    public string palabra;
    private string secreto = "domingo";
    // Start is called before the first frame update
    void Start()
    {
        if (palabra != secreto)
        {
            Debug.Log("Palabra incorrecta");
        }
        else
        {
            Debug.Log("Has adivinado la palabra");
        }
    }
}
