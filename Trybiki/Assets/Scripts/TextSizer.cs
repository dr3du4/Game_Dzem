using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Vector3 scaleFactor = new Vector3(0.2f, 0.2f, 0.2f); // Scale factor for the button when hovered
    public float transitionTime = 0.2f; // Time taken for the scaling transition
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        StartCoroutine(ScaleButton(originalScale + scaleFactor));
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StartCoroutine(ScaleButton(originalScale));
    }

    private System.Collections.IEnumerator ScaleButton(Vector3 targetScale)
    {
        float elapsedTime = 0f;
        Vector3 startScale = transform.localScale;

        while (elapsedTime < transitionTime)
        {
            transform.localScale = Vector3.Lerp(startScale, targetScale, (elapsedTime / transitionTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.localScale = targetScale;
    }
}
