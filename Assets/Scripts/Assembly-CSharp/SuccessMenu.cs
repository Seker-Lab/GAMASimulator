using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccessMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextMask()
    {
        SceneManager.LoadScene("Mask2");
        Time.timeScale = 1f;
    }



    public void BackMain()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;
    }

    public void MaskSelect()
    {
        SceneManager.LoadScene("Mask Menu");
        Time.timeScale = 1f;
    }
}
