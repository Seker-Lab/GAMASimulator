using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOutUI : MonoBehaviour
{
    public float fadeInDuration = 1f;
    public float displayDuration = 2f;
    public float fadeOutDuration = 1f;

    private CanvasGroup canvasGroup;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;
    }

    public IEnumerator FadeInOut()
    {
        // Fade in
        float fadeInStartTime = Time.time;
        while (Time.time < fadeInStartTime + fadeInDuration)
        {
            canvasGroup.alpha = (Time.time - fadeInStartTime) / fadeInDuration;
            yield return null;
        }

        canvasGroup.alpha = 1f;

        // Display
        yield return new WaitForSeconds(displayDuration);

        // Fade out
        float fadeOutStartTime = Time.time;
        while (Time.time < fadeOutStartTime + fadeOutDuration)
        {
            canvasGroup.alpha = 1f - (Time.time - fadeOutStartTime) / fadeOutDuration;
            yield return null;
        }

        canvasGroup.alpha = 0f;
    }
}
