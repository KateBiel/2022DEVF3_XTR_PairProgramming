using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLoseCondition : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("LOST!!! Your Mom has reached the soccer field! Time to go home :( ");
            ScoreManager.Instance.currentScore = 0;
        }
    }
    
}
