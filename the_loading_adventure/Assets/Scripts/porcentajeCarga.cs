using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class porcentajeCarga : MonoBehaviour
{

    public int porcentaje = 0;
    public float tiempo = 0.25f;
    Text texto;

    public puntuacion puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<Text>();
        StartCoroutine(AumentarPorcentaje());
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "Cargando: " + porcentaje + "%";
    }

    public IEnumerator AumentarPorcentaje()
    {

        while(porcentaje < 100)
        {
            yield return new WaitForSeconds(tiempo);
            porcentaje++;
        }

        PlayerPrefs.SetInt("score", puntuacion.score);

        SceneManager.LoadScene("player");

    }

}
