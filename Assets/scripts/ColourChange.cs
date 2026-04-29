using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour
{
    public Renderer[] objectsToChange;
    public Color[] colorsToUse;

    private Color[] originalColors;

    void Start()
    {
        originalColors = new Color[objectsToChange.Length];

        for (int i = 0; i < objectsToChange.Length; i++)
        {
            originalColors[i] = objectsToChange[i].material.color;
        }
    }

    public void ChangeColor()
    {
        StartCoroutine(ChangeRoutine());
    }

    IEnumerator ChangeRoutine()
    {
        for (int i = 0; i < objectsToChange.Length; i++)
        {
            objectsToChange[i].material.color = colorsToUse[i % colorsToUse.Length];
        }

        yield return new WaitForSeconds(10f);

        for (int i = 0; i < objectsToChange.Length; i++)
        {
            objectsToChange[i].material.color = originalColors[i];
        }
    }
}
