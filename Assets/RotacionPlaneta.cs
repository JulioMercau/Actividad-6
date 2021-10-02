using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPlaneta : MonoBehaviour
{

    private int direccion = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.identity;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, direccion, 0 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            //transform.Rotate(0, -1, 0 * Time.deltaTime);
            direccion = -1;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            //transform.Rotate(0, 1, 0 * Time.deltaTime);
            direccion = 1;
        }


       


    }
}

