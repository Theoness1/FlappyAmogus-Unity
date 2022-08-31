using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Amogus _amogus;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _amogus.ScoreChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        _amogus.ScoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int score)
    {
        _score.text = score.ToString();
    }
}
