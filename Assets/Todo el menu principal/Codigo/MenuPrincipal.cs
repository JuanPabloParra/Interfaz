using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void LoadScene(string name)
    {

        SceneManager.LoadScene(name);

    }

    public void CerrarJuego()
    {
        Application.Quit();
        Debug.Log("Salir");
    }



}
