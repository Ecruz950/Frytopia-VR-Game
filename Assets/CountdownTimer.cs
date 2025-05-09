
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountdownTimer : MonoBehaviour
{
    public Button startButton;
    public TextMeshProUGUI timerText;

    private Coroutine countdownCoroutine;

    void Start()
    {
        startButton.onClick.AddListener(StartCountdown);
    }

    void StartCountdown()
    {
        if (countdownCoroutine == null)
        {
            int startingTime = 10;

            // Try to parse the current text value as an integer
            int.TryParse(timerText.text, out startingTime);

            countdownCoroutine = StartCoroutine(CountdownCoroutine(startingTime));
        }
    }


    IEnumerator CountdownCoroutine(int seconds)
    {
        int timeLeft = seconds;
        while (timeLeft >= 0)
        {
            timerText.text = timeLeft.ToString();
            yield return new WaitForSeconds(1f);
            timeLeft--;
        }

        countdownCoroutine = null; // Reset when done
    }
}

