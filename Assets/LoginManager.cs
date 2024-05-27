using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField contraseña;
 
    public void MensajeEnConsola() 
    {
       
        
        string contraseñaa = "mewing123";
       
      if (contraseña.text == contraseñaa)
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access denied");
        }
    
    }
}
