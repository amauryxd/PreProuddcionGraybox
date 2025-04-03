using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explison : MonoBehaviour
{
    public void Explotar(){
        Debug.Log("bum");
        GetComponent<Rigidbody>().AddExplosionForce(Random.Range(5,25),this.transform.position,Random.Range(5,25));
    }
}
