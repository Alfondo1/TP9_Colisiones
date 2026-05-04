using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUIManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI textoScore;

    void Start()
    {
        ActualizarUI();
    }

    public void AddPointAndUpdateScoreUI()
    {
        score++;
        ActualizarUI();
    }

    void ActualizarUI()
    {
        textoScore.text = "Puntaje: " + score;
    }
}