using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{
    // Start is called before the first frame update
    void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            Debug.Log("Finish line crossed");
        {

            }

            // Update is called once per frame
            void Update()
            {

            }
        }
    } }
