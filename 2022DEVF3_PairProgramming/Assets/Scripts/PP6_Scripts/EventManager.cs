using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EventManager : MonoBehaviour
{
    public event System.Action<float> SpacebarPressed;

    public float passedFloat;



    public void SpacebarPress(InputAction.CallbackContext context)
    {
        
       // Debug.Log("Received spacebar press with a context of: " + context.phase);
        if (context.performed)
        {
            SpacebarPressed?.Invoke(passedFloat);
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
