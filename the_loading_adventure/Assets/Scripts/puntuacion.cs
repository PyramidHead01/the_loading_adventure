using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class puntuacion : MonoBehaviour
{

    public int score = 0;
    public int quitar = 2, anadirScore = 5;
    public int puntuacionLoading = 10, puntuacionJuego = 1 , puntuacionTeclas;

    public Text puntuacionTexto;

    public porcentajeCarga porcentajeCarga;


    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("score");
        StartCoroutine(AumentarPuntuacion());
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionTexto.text = score.ToString();

    }

    public void RestarPorcentaje()
    {
        if(porcentajeCarga.porcentaje - quitar >= 0)
        {
            porcentajeCarga.porcentaje -= quitar;
            score += anadirScore;
        }
    }

    public IEnumerator AumentarPuntuacion()
    {

        while (porcentajeCarga.porcentaje < 100)
        {
            if (SceneManager.GetActiveScene().ToString() != "ASD")
            {
                score += puntuacionLoading;
            }
            else if (score > 0)
            {
                score -= puntuacionJuego;
            }
            yield return new WaitForSeconds(0.5f);
        }

    }

}
