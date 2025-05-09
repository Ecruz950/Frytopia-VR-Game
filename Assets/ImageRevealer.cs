using UnityEngine;
using UnityEngine.UI;

public class ImageRevealer : MonoBehaviour
{
    public GameObject imageToShow; // Assign in Inspector

    public void ShowImage()
    {
        if (imageToShow != null)
            imageToShow.SetActive(true);
    }
}

