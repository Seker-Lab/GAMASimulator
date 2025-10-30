using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaskMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LoadMask1()
    {
        SceneManager.LoadScene("Mask1");
    }

    public void LoadMask2()
    {
        SceneManager.LoadScene("Mask2");
    }
}
