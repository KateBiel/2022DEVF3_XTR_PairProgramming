using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PP3_EndTriggerBox : MonoBehaviour
{
    public PP3_PlayerMovement rlgl;

   

    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.CompareTag("Player"))
        {
            rlgl.wonGame = true;
            Debug.Log("CONGRATS!!! You are alive!!!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
