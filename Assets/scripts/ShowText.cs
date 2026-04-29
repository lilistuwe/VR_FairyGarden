using UnityEngine;

public class ShowText : MonoBehaviour
{
    public GameObject textObject;

    public void Toggle()
    {
        textObject.SetActive(!textObject.activeSelf);
    }
}