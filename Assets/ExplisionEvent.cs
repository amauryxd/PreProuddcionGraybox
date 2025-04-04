using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplisionEvent : MonoBehaviour
{
    public GameObject[] cajas;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            foreach(GameObject caja in cajas){
                caja.GetComponent<Explison>().Explotar();
            }
        }
    }
}
