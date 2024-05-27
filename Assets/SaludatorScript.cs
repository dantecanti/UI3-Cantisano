using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaludatorScript : MonoBehaviour
{
    public InputField txtsaludo;
    public Text texto;
   public void MostrarHolaMasNombre()
    {
        
        texto.text = "Hola " + txtsaludo.text;
    }
}
