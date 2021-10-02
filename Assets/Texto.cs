using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texto : MonoBehaviour
{

    TextMesh texto;
    
    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            texto.text = "Derecha";
            texto.color = UnityEngine.Color.red;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            texto.text = "Izquierda";
            texto.color = UnityEngine.Color.blue;
        }
    }
}
