using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineScript : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }
	
	// Update is called once per frame
	void Update () {

       /* if OnTriggerOverlap(OnTriggerOverlap, other)
        {

        }
        ian is a poopy head with a smol peen. teehee.*/
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
