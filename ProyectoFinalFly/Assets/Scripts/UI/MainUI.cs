using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cargando Escena");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickPlay()
    {
        Debug.Log("Se presiono el boton play");
        SceneManager.LoadScene("Level1");
    }

    public void OnReload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
