using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Difficulty : MonoBehaviour
{
    public Camera mainCamera;
    public TMP_Dropdown difficultyDropdown;
    public Button zoomOutButton;
    public GameObject hintHUD;
    public GameObject hintButton;

    private void Start()
    {
        zoomOutButton.gameObject.SetActive(true);
        difficultyDropdown.onValueChanged.AddListener(OnDifficultyChanged);
        hintHUD.SetActive(false);
    }

    private void OnDifficultyChanged(int index)
    {
        if (index == 0) // Easy mode
        {
            zoomOutButton.gameObject.SetActive(true);
            hintButton.SetActive(true);
            mainCamera.orthographicSize = 18f;
        }
        else if (index == 1) // Hard mode
        {
            zoomOutButton.gameObject.SetActive(false);
            mainCamera.orthographicSize = 2f;
            hintHUD.SetActive(false);
            hintButton.SetActive(false);
        }
    }
}
