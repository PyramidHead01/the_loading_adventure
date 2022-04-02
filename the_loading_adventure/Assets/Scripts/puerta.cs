using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puerta : MonoBehaviour
{

    public bool dentro = false;

    #region Colisiones
    void OnTriggerEnter2D(Collider2D other)
    {

        dentro = true;

    }
    void OnTriggerExit2D(Collider2D other)
    {

        dentro = false;

    }

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dentro && Input.GetKey(KeyCode.Space))
        {
            //int numEscena = PlayerPrefs.GetInt("numEscena");
            //PlayerPrefs.SetInt("numEscena", numEscena++);
            //PlayerPrefs.SetString("escena", modificableDialogo.escenaSiguiente);
            //SceneManager.LoadScene(modificableDialogo.escenaSiguiente);
            SceneManager.LoadScene("PantallaDeCargaBase");
        }
    }
}
