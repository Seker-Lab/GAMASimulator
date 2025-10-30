using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObj; 
    public float moveSpeed = 1.0f; 
    public float rotationSpeed = 1.0f;

    private void Start()
    {
        Debug.Log("Time.timeScale: " + Time.timeScale);
    }


    public void OnUpButtonClick()
    {
        gameObj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    
    public void OnDownButtonClick()
    {
        gameObj.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }

    
    public void OnLeftButtonClick()
    {
        gameObj.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    
    public void OnRightButtonClick()
    {
        gameObj.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    
    public void OnClockwiseButtonClick()
    {
        gameObj.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    
    public void OnCounterclockwiseButtonClick()
    {
        gameObj.transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
