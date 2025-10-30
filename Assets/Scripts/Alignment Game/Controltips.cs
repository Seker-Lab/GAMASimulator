using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controltips : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hintText;

    private bool isHintVisible = false;

    private void Start()
    {
        hintText.gameObject.SetActive(false);
    }

    public void ToggleHint()
    {
        isHintVisible = !isHintVisible;
        hintText.gameObject.SetActive(isHintVisible);
    }
}
