using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnocking : MonoBehaviour {

	public AudioSource sound ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if(other.name == "RigidBodyFPSController") {
			sound.Play();
			StartCoroutine(StopMusic());
		}
	}

	  IEnumerator StopMusic()
    {
    	yield return new WaitForSeconds(3.0f);
    	sound.Stop();
    }

}
