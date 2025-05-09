using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ButtonCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText; // Assign this in the Inspector
    private int counter = 0;

    private void Start()
    {
        // Hook into the button press event
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(OnButtonPressed);

        // Optional: set initial display
        UpdateCounterDisplay();
    }

    private void OnButtonPressed(SelectEnterEventArgs args)
    {
        counter += 10;
        UpdateCounterDisplay();
    }

    private void UpdateCounterDisplay()
    {
        if (counterText != null)
            counterText.text = counter.ToString();
    }
}

