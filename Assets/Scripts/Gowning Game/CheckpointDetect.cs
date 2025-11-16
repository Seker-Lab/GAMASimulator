using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointDetect : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;
    [SerializeField] CharacterController player;
    [SerializeField] float timerSeconds = 2f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 100f, layerMask))
        {
            timer += Time.deltaTime;
            Debug.Log(hit.collider.bounds.center);
            if (timer >= timerSeconds)
            {
                Debug.Log("TELEPORT");
                player.enabled = false;
                player.transform.position = hit.collider.bounds.center;
                player.enabled = true;
                timer = 0;
            }
        }
        else
        {
            timer = 0f;
        }

    }
}
