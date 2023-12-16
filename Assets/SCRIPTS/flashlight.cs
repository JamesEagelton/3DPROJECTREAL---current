using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
  public GameObject flashlightobject;
    public GameObject cam;
    private Light myLight;


    private void Start()
    {
        myLight = GetComponent<Light>();
    }
    void Update()
    {
       flashlightobject.transform.rotation = cam.transform.rotation;

        if (Input.GetKeyDown(KeyCode.F)) 
        { 
            myLight.enabled = !myLight.enabled;
        }
    }
}
