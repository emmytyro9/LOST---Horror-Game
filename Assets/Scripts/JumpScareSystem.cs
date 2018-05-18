using UnityEngine;
using System.Collections;

public class JumpScareSystem : MonoBehaviour {

public Animator animator;
public AudioSource sound;
public AudioSource heartBeat;


	void Start(){
        sound.Stop();
        heartBeat.Stop();
	}

	public void OnTriggerEnter (Collider other){
	  if(other.name == "RigidBodyFPSController") {
          sound.Play();
          heartBeat.Play();
          StartCoroutine(DestroyObject());   
      }
			 
		}

    IEnumerator DestroyObject(){
	    yield return new WaitForSeconds(2.0f);
        sound.Stop();
		Destroy(this);
        yield return new WaitForSeconds(2.0f);
        heartBeat.Stop();
	}
}
	
	