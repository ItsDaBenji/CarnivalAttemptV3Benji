using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMBFillCanister : MonoBehaviour
{

    [SerializeField] float currentFill = 0, maxFill;

    [SerializeField] float fillRate;

    [SerializeField] int scoreValue;

    [SerializeField] float destroyTime;

    private void OnEnable()
    {
        Destroy(gameObject, destroyTime);
    }

    private void FillCanister()
    {
        Debug.Log("Filling");
        currentFill += fillRate * Time.deltaTime;
        if(currentFill >= maxFill)
        {
            Debug.Log("CompletelyFilled");
            BMBGameManager.instance.score += scoreValue;
            Destroy(gameObject);
        }
    }

}
