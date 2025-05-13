using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public SkapisScript skapisScript;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;

        if (dropped != null)
        {
            dropped.transform.SetParent(this.transform);
            dropped.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

            // Сохраняем как надетый
            if (skapisScript != null)
            {
                skapisScript.MarkAsWorn(dropped);
            }
        }
    }
}
