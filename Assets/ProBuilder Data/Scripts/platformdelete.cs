using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformdelete : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) ;

        Destroy( this.gameObject, 1);
    }
     
    // Update is called once per frame
    void Update()
    {
        
    }
}
