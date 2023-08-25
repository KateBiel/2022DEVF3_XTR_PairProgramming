using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public MeshRenderer[] renders;

    public MeshRenderer[] rendersGlass;

    public MeshRenderer[] rendersDetails;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeColorBase(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rend in renders) 
        {
            rend.material.color = receivedColor.heldColor;
        }
    }

    public void ChangeColorGlass(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendG in rendersGlass)
        {
            rendG.material.color = receivedColor.heldColor;
        }
    }

    public void ChangeColorDetails(ColorHolder receivedColor)
    {
        foreach (MeshRenderer rendD in rendersDetails)
        {
            rendD.material.color = receivedColor.heldColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
