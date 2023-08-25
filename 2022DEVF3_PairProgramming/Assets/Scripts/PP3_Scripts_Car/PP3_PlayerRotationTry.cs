using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PP3_PlayerRotationTry : MonoBehaviour
{
    public KeyCode GoForward;
    public KeyCode GoBack;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(GoForward) || Input.GetKey(GoBack))
        {
            GetComponent<Transform>().eulerAngles = (new Vector3(0f, 0f, 0f));
            if (Input.GetKeyDown(GoForward) || Input.GetKeyDown(GoBack))

            { 

                Debug.Log("I think I can go now!");
            }

        }
        else
        {
            if (Input.GetKeyUp(GoForward) || Input.GetKeyUp(GoBack))
            {
                Debug.Log("So scared!!! I should take a breake!!!");
            }
           

            GetComponent<Transform>().eulerAngles = (new Vector3(0f, -180f, 0f));

        }

    }

  
}
