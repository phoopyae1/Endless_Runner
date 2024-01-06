using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCoin : MonoBehaviour
{
   public GameObject thePlayer;
   public GameObject charModel;
   public AudioSource crashThud;
   public GameObject mainCam;
   public GameObject levelControl;
 
    // Start is called before the first frame update
 void OnTriggerEnter(Collider other)
 {    this.gameObject.GetComponent<BoxCollider>().enabled=false;
     thePlayer.GetComponent<PlayerMove>().enabled=false;
     charModel.GetComponent<Animator>().Play("Stumble Backwards");
     levelControl.GetComponent<LevelDistance>().enabled=false;
     crashThud.Play();
     mainCam.GetComponent<Animator>().enabled=true;
     levelControl.GetComponent<EndRunSequence>().enabled=true;
 }
}
