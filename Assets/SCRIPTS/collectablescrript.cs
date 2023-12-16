using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectablescrript : MonoBehaviour
{
   bool playerhaskey = false;
   public Text text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerhaskey = true;
            text.text = "Objective : Get On The Boat On The Coast Of The City";
            Destroy(this.gameObject);
        }
    }

}
