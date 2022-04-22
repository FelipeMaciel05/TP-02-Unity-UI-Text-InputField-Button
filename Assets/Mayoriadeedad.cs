using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mayoriadeedad : MonoBehaviour
{
    public int Edad;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Edad >= 18)
        {
            
            Debug.Log("Es mayor de edad");
        }
        else
        {
            
            Debug.Log("Es menor");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
