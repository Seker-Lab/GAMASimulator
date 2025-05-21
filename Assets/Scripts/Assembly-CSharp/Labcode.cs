using UnityEngine;
using UnityEngine.UI;

public class Labcode : MonoBehaviour
{
    public KeyCode interactionKey = KeyCode.F;
    public FadeInOutUI successTextFadeScript;
    public FadeInOutUI wrongOrderTextFadeScript;
    public GameObject[] items;
    public Text[] itemTexts;
    public GameObject mobileSpace;
    private int currentItemIndex = 0;
    private void Start()
    {
        
    }
    private void Update()
    {

        if (Input.GetKeyDown(interactionKey) && !DeviceType.IsMobileBrowser())
        {
            Interact();
        }
    }

    public void Interact() {
     RaycastHit hit;
             GameObject nextLevel = GameObject.Find("NextLevel");
        NextScene myScript = nextLevel.GetComponent<NextScene>();
    if (Physics.Raycast(transform.position, transform.forward, out hit))
    {
        
        if (ArrayContainsObject(items, hit.collider.gameObject))
        {
            if (hit.collider.gameObject == items[currentItemIndex])
            {
                InteractWithItem(currentItemIndex);

                
                if (currentItemIndex >= items.Length - 1)
                {
                    
                    if (successTextFadeScript != null)
                    {
                        StartCoroutine(successTextFadeScript.FadeInOut());
                        myScript.enabled = true;
                        mobileSpace.SetActive(true);
                    }
                }
                else
                {
                    currentItemIndex++;
                }
            }
            else
            {
                
                if (wrongOrderTextFadeScript != null)
                {
                    StartCoroutine(wrongOrderTextFadeScript.FadeInOut());
                }
            }
        }
    }
    }

    private void InteractWithItem(int itemIndex)
    {
        
        items[itemIndex].SetActive(false);
        itemTexts[itemIndex].gameObject.SetActive(true);
       
    }

    private bool ArrayContainsObject(GameObject[] array, GameObject obj)
    {
        foreach (GameObject item in array)
        {
            if (item == obj)
            {
                return true;
            }
        }
        return false;
    }
}
