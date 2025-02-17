using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseWafer : MonoBehaviour
{
    public GameObject WaferSelect;
    public GameObject MainUI;
    public GameObject FirstWafer;
    public GameObject SecondWafer;
    // Start is called before the first frame update
    void Start()
    {
        MainUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Wafer1()
    {
        FirstWafer.SetActive(true);
        SecondWafer.SetActive(false);
        WaferSelect.SetActive(false);
        MainUI.SetActive(true);
    }

    public void Wafer2()
    {
        SecondWafer.SetActive(true) ;
        FirstWafer.SetActive(false) ;
        WaferSelect.SetActive(false) ;
        MainUI.SetActive(true) ;
    }

    public void Select()
    {
        MainUI.SetActive(false );
        WaferSelect.SetActive(true);
    }
}
