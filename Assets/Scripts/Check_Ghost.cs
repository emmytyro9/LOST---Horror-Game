using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check_Ghost : MonoBehaviour {

	 public GameObject Ghost;
	 public AudioSource sound;

    void Start () {

        Ghost.SetActive(false);
	}
	
	void OnTriggerEnter (Collider player) {
        if(player.name == "RigidBodyFPSController")
        {
            Ghost.SetActive(true);
			sound.Play();
            StartCoroutine(DestroyObject());
        }		
	}

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(Ghost);
        sound.Stop();
    }
}
