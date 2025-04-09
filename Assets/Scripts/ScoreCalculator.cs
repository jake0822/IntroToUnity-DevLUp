using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    private float timeAlive;
    private bool PlayerScoring;

    public TextMeshPro[] Texts;
    public TextMeshProUGUI UIText;

    private void OnTriggerEnter(Collider other)
    {
        PlayerScoring = true;
        timeAlive = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerScoring = false;
    }

    private void FixedUpdate()
    {
        if (PlayerScoring == true)
        {
            timeAlive += Time.deltaTime;
            foreach (var text in Texts)
            {
                text.text = MathF.Round(timeAlive).ToString();
            }
            UIText.text = "SCORE: "+ MathF.Round(timeAlive).ToString();
        }
    }
}
