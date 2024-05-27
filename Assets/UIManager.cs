using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text txtFrutas;
    public string[] frutas = { "banana", "pera", "papaya", "mango" };
    int random = Random.Range(1 , 4);

    public void UpdateFruta()
    {
        txtFrutas.text = frutas[Random.Range(0, frutas.Length)];

    }
}
