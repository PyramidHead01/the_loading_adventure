using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderGears : MonoBehaviour
{

    Slider slider;

    public float movSlider = 5, tiempoSlider = 0.05f, rangMin = 0.3f, rangMax = 0.8f;

    public porcentajeCarga porcentajeCarga;
    public puntuacion puntuacion;

    bool adelante = true;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 0)
        {
            adelante = true;
            StartCoroutine(AvanzarSlider());
        }
        else if(slider.value == 1)
        {
            adelante = false;
            StartCoroutine(AtrasSlider());
        }

        if ((slider.value > rangMin && slider.value < rangMax) && Input.GetKey(KeyCode.Mouse0))
        {
            puntuacion.RestarPorcentaje();
            Debug.Log("AAAA");
        }

    }

    IEnumerator AvanzarSlider()
    {

        StopCoroutine(AtrasSlider());

        while(adelante) //(slider.value <= 1)
        {
            slider.value = slider.value + movSlider;
            yield return new WaitForSeconds(tiempoSlider);
        }

    }

    IEnumerator AtrasSlider()
    {

        StopCoroutine(AvanzarSlider());

        while (!adelante) //(slider.value >= 0)
        {
            slider.value = slider.value - movSlider;
            yield return new WaitForSeconds(tiempoSlider);
        }

    }

}
