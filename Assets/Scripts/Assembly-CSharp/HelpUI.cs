using UnityEngine;

public class HelpUI : MonoBehaviour
{
    public GameObject helpPanel;

    private bool isShowing = false;
    private bool holdingHelp = false;

    private void Start()
    {
       
        helpPanel.SetActive(false);
    }

    private void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
            holdingHelp = Input.GetKey(KeyCode.H);
        if (holdingHelp)
        {
            if (!isShowing)
            {
                ShowHelpPanel();
            }
        }
        else
        {
            if (isShowing)
            {
                HideHelpPanel();
            }
        }
    }

    public void ToggleHelp() {
        holdingHelp = !holdingHelp;
    }

    private void ShowHelpPanel()
    {
        helpPanel.SetActive(true);
        isShowing = true;
    }

    private void HideHelpPanel()
    {
        helpPanel.SetActive(false);
        isShowing = false;
    }
}
