using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplisionEvent : MonoBehaviour
{
    public GameObject[] cajas;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            Debug.Log("hello");
            //foreach(GameObject caja in cajas){
                //caja.GetComponent<Explison>().Explotar();
            //}
            for(int i = 0; i < cajas.Length; i++){
                cajas[i].GetComponent<Explison>().Explotar();
            }
        }
    }
}
