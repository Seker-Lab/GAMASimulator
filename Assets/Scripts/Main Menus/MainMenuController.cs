using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;
    public Button creditsPage;
    public Button maskAlignment;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
        creditsPage.onClick.AddListener(Creditpage);
        maskAlignment.onClick.AddListener(MaskAlignment);
    }

    void StartGame()
    {

        SceneManager.LoadScene("Lab");
    }

    void ExitGame()
    {
        Application.Quit();
    }

    void Creditpage()
    {
        SceneManager.LoadScene("Credits");
    }
    void MaskAlignment()
    {
        SceneManager.LoadScene("Mask Menu");
    }
}
