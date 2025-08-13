using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ListaToggle : MonoBehaviour
{
    public GameObject Abrir;           // Referência ao botão
    public GameObject Lista;   

    

    void Start()
    {



    }
    public void AbrirLista()
    {
        Abrir.SetActive(false);
        Lista.SetActive(true);
    }

    public void FecharLista()
    {
        Debug.Log("Oi");
        Abrir.SetActive(true);
        Lista.SetActive(false);
    }


  
}
