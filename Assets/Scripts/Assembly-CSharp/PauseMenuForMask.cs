using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuForMask : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseMenu;
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            TogglePauseMenu();
        }
    }
    public void TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);

        if (pauseMenu.activeSelf)
        {
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Main Menu");
    }
    public void ReturnToMaskSelect()
    {
        Time.timeScale=1f;
        Cursor.visible = true;
        Cursor.lockState= CursorLockMode.None;
        SceneManager.LoadScene("Mask Menu");
    }

    public void FullScreenToggle()
    {
        if (Screen.fullScreen)
        {
            Screen.fullScreen = false;
        }
        else
        {
            Screen.fullScreen = true;
        }
    }
}
