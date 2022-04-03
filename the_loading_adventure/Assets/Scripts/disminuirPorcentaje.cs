using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disminuirPorcentaje : MonoBehaviour
{

    public porcentajeCarga porcentajeCarga;

    puntuacion puntuacion;

    public GameObject sliderGO;

    // Start is called before the first frame update
    void Start()
    {
        puntuacion = GetComponent<puntuacion>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0) && !sliderGO.activeSelf)
        {
            puntuacion.RestarPorcentaje();
        }
    }
}
