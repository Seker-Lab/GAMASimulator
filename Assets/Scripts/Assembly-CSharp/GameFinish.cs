using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFinish : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objectTransform;
    
    public float minXRotation = -91f;
    public float maxXRotation = -89f;
    public GameObject completionHUD;
    

    private bool isCompleted = false;

    private void Update()
    {
        if (!isCompleted &&
            objectTransform.position.x >= -0.60f && objectTransform.position.x <= -0.45f &&
            objectTransform.position.y >= -0.60f && objectTransform.position.y <= -0.45f &&
            IsRotationInRange(objectTransform.eulerAngles.x, minXRotation, maxXRotation))
        {
            isCompleted = true;
            completionHUD.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    private bool IsRotationInRange(float rotation, float minRange, float maxRange)
    {
        rotation = NormalizeRotation(rotation);
        minRange = NormalizeRotation(minRange);
        maxRange = NormalizeRotation(maxRange);

        if (minRange <= maxRange)
        {
            return rotation >= minRange && rotation <= maxRange;
        }
        else
        {
            return rotation >= minRange || rotation <= maxRange;
        }
    }

    private float NormalizeRotation(float rotation)
    {
        if (rotation > 180f)
        {
            return rotation - 360f;
        }
        else if (rotation < -180f)
        {
            return rotation + 360f;
        }

        return rotation;
    }




}
