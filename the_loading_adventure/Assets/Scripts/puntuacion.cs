using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntuacion : MonoBehaviour
{

    public int score = 0;
    public Text puntuacionTexto;


    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("score");
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionTexto.text = score.ToString();
    }

    public void SumarPuntuacion(int i)
    {
        score += i;
    }

}
