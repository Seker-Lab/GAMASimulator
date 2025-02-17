using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text helpText;
    public TMP_Text helpText2;

    void Start()
    {
        int difficulty = PlayerPrefs.GetInt("Difficulty", 0);

        if (difficulty == 0)
        {
            
            helpText.gameObject.SetActive(true);
            helpText2.gameObject.SetActive(true);
        }
        else
        {
           
            helpText.gameObject.SetActive(false);
            helpText2.gameObject.SetActive(false);
        }
    }
}
