using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectableControll : MonoBehaviour
{    public static int coinCount;
public GameObject coinCountDisplay;
public GameObject coinEndDisplay;
    // Start is called before the first frame update
   void Update()
   {
 coinCountDisplay.GetComponent<Text>().text = "" + coinCount;
 coinEndDisplay.GetComponent<Text>().text = "" + coinCount;
   }
}
