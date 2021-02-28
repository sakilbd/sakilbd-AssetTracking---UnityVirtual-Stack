using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour
{
public GameObject camera1;
     public GameObject camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown("q"))
               {
                  camera1.SetActive(true);
                    camera2.SetActive(false);
                    Debug.Log("cameraswitchButton Pressed");
               }
               if (Input.GetKeyDown("e"))
                              {
                                 camera1.SetActive(false);
                                   camera2.SetActive(true);
                                   Debug.Log("cameraswitchButton Pressed");
                              }

    }
}
