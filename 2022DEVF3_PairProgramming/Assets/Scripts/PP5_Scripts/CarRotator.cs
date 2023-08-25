using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public void RotateCar(float sliderValue)
    {
        Vector2 newRotation = new Vector3(0, sliderValue, 0);
        transform.rotation = Quaternion.Euler(newRotation);
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
