using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disminuirPorcentaje : MonoBehaviour
{

    public porcentajeCarga porcentajeCarga;

    public int quitar = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && porcentajeCarga.porcentaje - quitar >= 0)
        {
            porcentajeCarga.porcentaje -= quitar;
        }
    }
}
