using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyscript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool keyget = false;
    public GameObject key;
    public Text text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            Destroy(key.gameObject);
            keyget = true;
            text.text = "Objective : Go To The Boat At The City Lake";
        
        }
    }
}
