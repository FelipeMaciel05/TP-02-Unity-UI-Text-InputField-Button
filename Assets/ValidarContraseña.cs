using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseñaCorrecta = "123";
    string contraseñaUsuario;
    public Text IngresoU;
    public Text textomsj;
    public GameObject cartelitomsj;
    // Start is called before the first frame update
    void Start()
    {
        cartelitomsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void validarContraseña()
    {
        contraseñaUsuario = IngresoU.text;
        if (contraseñaUsuario == contraseñaCorrecta)
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "Contraseña Incorrecta";
            Debug.Log("contraseña incorrecta");
        }
    }

}
