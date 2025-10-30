using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSizeController : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mainCamera;
    public float targetXPosition = -9f;
    public float backPosition = 0f;

    public void Center()
    {
        mainCamera.orthographicSize = 2f;
        Vector3 backPos= mainCamera.transform.position;
        backPos.x= backPosition;
        mainCamera.transform.position=backPos;
    }

    public void ZoomLeft()
    {
        mainCamera.orthographicSize = 2f;
        Vector3 newPosition = mainCamera.transform.position;
        newPosition.x = targetXPosition;
        mainCamera.transform.position = newPosition;
    }

    public void ZoomOut()
    {
        mainCamera.orthographicSize = 18f;
        Vector3 backPos = mainCamera.transform.position;
        backPos.x= backPosition;
        mainCamera.transform.position=backPos;
    }

}
