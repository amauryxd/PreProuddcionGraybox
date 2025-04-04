using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    public GameObject elcoso;
    public void aparecerObjetoBlock(){
        elcoso.SetActive(true);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            aparecerObjetoBlock();
        }
    }
}
