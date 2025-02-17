using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public KeyCode interactionKey = KeyCode.F;
    public FadeInOutUI successTextFadeScript;
    public FadeInOutUI wrongOrderTextFadeScript;
    public GameObject carpet;
    public GameObject shoes;
    public Collider doorCollider;
    public Collider frameCollider;
    public Collider carpetCollider;

    private bool isCarpetInteracted = false;
    private bool isShoesInteracted = false;

    private void Update()
    {
        
        if (Input.GetKeyDown(interactionKey))
        {
            
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                
                if (hit.collider.gameObject == carpet)
                {
                    if (!isCarpetInteracted && !isShoesInteracted)
                    {
                        InteractWithCarpet();
                        return;
                    }
                    else
                    {
                        
                        if (wrongOrderTextFadeScript != null)
                        {
                            StartCoroutine(wrongOrderTextFadeScript.FadeInOut());
                        }
                        return;
                    }
                }
                
                else if (hit.collider.gameObject == shoes)
                {
                    if (isCarpetInteracted && !isShoesInteracted)
                    {
                        InteractWithShoes();
                        return;
                    }
                    else
                    {
                        
                        if (wrongOrderTextFadeScript != null)
                        {
                            StartCoroutine(wrongOrderTextFadeScript.FadeInOut());
                        }
                        return;
                    }
                }
            }
        }
    }

    private void InteractWithCarpet()
    {
        
        if (carpet != null)
        {
            carpet.SendMessage("InteractWithCarpet");
            carpetCollider.enabled = false;
        }
        isCarpetInteracted = true;
        
        if (successTextFadeScript != null)
        {
            StartCoroutine(successTextFadeScript.FadeInOut());
        }
    }

    private void InteractWithShoes()
    {
        
        if (shoes != null)
        {
            shoes.SetActive(false);
        }
        isShoesInteracted = true;
        
        if (doorCollider != null)
        {
            doorCollider.enabled = false;
            frameCollider.enabled = false;
        }
    }
}
