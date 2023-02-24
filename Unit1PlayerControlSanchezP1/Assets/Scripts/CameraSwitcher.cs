using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject CockpitCamera;
    public GameObject MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && CockpitCamera.activeInHierarchy == true)
        { 
            CockpitCamera.SetActive(false);
            //MainCamera.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.C) && CockpitCamera.activeInHierarchy == false)
        {
            CockpitCamera.SetActive(true);
            //MainCamera.SetActive(false);
        }
    }
}
