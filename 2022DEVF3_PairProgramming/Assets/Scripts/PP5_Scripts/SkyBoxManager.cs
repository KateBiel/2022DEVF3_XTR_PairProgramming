using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void TimeOfDay(float xRotation)
    {
        Vector3 newRot = new Vector3(xRotation, transform.rotation.y, transform.rotation.z);
        transform.rotation = Quaternion.Euler(newRot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
