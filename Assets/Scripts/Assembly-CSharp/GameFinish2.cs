using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinish2 : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform objectTransform;

    public float minXRotation = -89f;
    public float maxXRotation = -87f;
    public GameObject completionHUD;
    private bool isCompleted = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isCompleted &&
     objectTransform.position.x >= -0.05f && objectTransform.position.x <= 0.04f &&
     objectTransform.position.y >= -0.05f && objectTransform.position.y <= 0.04f &&
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
