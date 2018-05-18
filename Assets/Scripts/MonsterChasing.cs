using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterChasing : MonoBehaviour {

	public AudioSource sound;
	public AudioSource scream;
	public GameObject game;
	// Use this for initialization
	void Start () {
		sound.Stop();
		game.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if(other.name == "RigidBodyFPSController") {
			sound.Play();
			scream.Play();
			game.SetActive(true);
		}
	}
}
