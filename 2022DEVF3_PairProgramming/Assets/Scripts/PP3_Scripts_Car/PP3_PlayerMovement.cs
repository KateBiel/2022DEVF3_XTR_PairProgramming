using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PP3_PlayerMovement : MonoBehaviour

{
    public  float speed = 1f;
    public  Vector3 movementVector;

    public bool canMove; // for debugging purpose make it public, just so that you can see in the Unity Editor during playtime
    public bool wonGame; // will tell the script when to stop
    public float minRedTime, maxRedTime, minGreenTime, maxGreenTime; // these will be the bounds of how long the red and green lights stay active

    public Transform respawnTransform;

    // declare two colors p
    public MeshRenderer stoplightRed;
    public Color redColor, greenColor;

    bool inLeniencyTime;
    public float leniencyFloat;



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            transform.position = respawnTransform.position;
            Debug.Log("OHHHH NO!!!! DOLL DETECTED YOU!!! ");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        canMove = true;
        wonGame = false;

        StartCoroutine(StoplightTimer());

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movementVector * Time.deltaTime * speed;

        if (!canMove)
        {
            if (movementVector.magnitude > 0f && !inLeniencyTime)
            {
                Debug.Log("YOU MOVED!!! YOU WAS SHOT!!!");
                transform.position = respawnTransform.position;
                
            }
        }
        else
        {
            transform.position += movementVector * Time.deltaTime * speed;

        }
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 movementVector2 = context.ReadValue<Vector2>();
        
        movementVector = new Vector3(movementVector2.x, 0, movementVector2.y);
    }
    IEnumerator StoplightTimer()
    {
        while (!wonGame)
        {
            if (canMove)
            {
                canMove = false;
                stoplightRed.sharedMaterial.color = redColor;
                StartCoroutine(LeniencyTimer());
                yield return new WaitForSeconds(Random.Range(minRedTime, maxRedTime));
                

            }
            else
            {
                canMove = true;
                stoplightRed.sharedMaterial.color = greenColor;
                yield return new WaitForSeconds(Random.Range(minGreenTime, maxGreenTime));
                
                
            }
        }
    }
    IEnumerator LeniencyTimer()
    {
        inLeniencyTime = true;
        yield return new WaitForSeconds(leniencyFloat);
        inLeniencyTime = false;
        
    }

}
