using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explison : MonoBehaviour
{
    public void Explotar(){
        GetComponent<Rigidbody>().AddExplosionForce(Random.Range(5,15),new Vector3(Random.Range(1,10),0,Random.Range(1,10)),Random.Range(50,100),0,ForceMode.Impulse);
    }

}
