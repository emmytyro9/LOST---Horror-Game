using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

    private Animator ani ;


	void Start(){
       ani = GetComponent<Animator>();
	}

    void Update() {

    }

	public void OnTriggerEnter (Collider other){
        if(other.name == "RigidBodyFPSController") {
        ani.SetBool("open", true);
        }
	}
}
	