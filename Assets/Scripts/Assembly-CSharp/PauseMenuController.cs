using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenu;
    public TMP_Dropdown difficultyOption;
    public Text helpText;
    public TMP_Text helpText2;
    void Start()
    {
        pauseMenu.SetActive(false);
        difficultyOption.onValueChanged.AddListener(DifficultyChanged);
    }

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
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Main Menu"); 
    }

    public void DifficultyChanged(int index)
    {
        if (index == 0) // Easy mode
        {
            helpText.gameObject.SetActive(true);
            helpText2.gameObject.SetActive(true);
        }
        else if (index == 1) // Hard mode
        {
            helpText.gameObject.SetActive(false);
            helpText2.gameObject.SetActive(false);
        }
    }

}
