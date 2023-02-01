using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int counter;
    [SerializeField] TextMeshProUGUI countText;
    [SerializeField] TextMeshProUGUI timeText;

    [SerializeField] GameObject MenuPanel;

    float currentTime;
    float startingTime = 10;

    private void Start()
    {
        currentTime = startingTime;
    }

    public void Update()
    {
        countText.text = "Counter: " + counter.ToString();
        Timer();

        if (currentTime > 0)
        {
            Timer();
            MenuPanel.SetActive(false);
        }
        else
        {
            MenuPanel.SetActive(true);
        }
    }

    void Timer()
    {
        currentTime -= 1 * Time.deltaTime;
        timeText.text = currentTime.ToString("0");
    }
}