using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource coinFX;
 void OnTriggerEnter(Collider other)
 {
    coinFX.Play();
    CollectableControll.coinCount +=1;
    this.gameObject.SetActive(false);
 }
}
