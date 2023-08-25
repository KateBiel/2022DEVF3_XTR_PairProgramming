using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Event : MonoBehaviour
{
    public EventManager evMan;

    // Start is called before the first frame update
    void Start()
    {
        evMan.SpacebarPressed += MoveRight;
    }

    private void OnDestroy()
    {
        evMan.SpacebarPressed -= MoveRight;
    }

    void MoveRight(float recievedFloat)
    {
        transform.position += new Vector3(recievedFloat, 0f, 0f);
    }
}
