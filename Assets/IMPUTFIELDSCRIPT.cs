using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IMPUTFIELDSCRIPT : MonoBehaviour

{
    public InputField Inputnombre;

   
    public void EscribirNombreEnConsola()
    {
        Debug.Log(Inputnombre.text);
    }
}
