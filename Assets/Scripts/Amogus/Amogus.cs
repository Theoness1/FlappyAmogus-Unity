using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AmogusMover))]
public class Amogus : MonoBehaviour
{
    private AmogusMover _mover;
    private int _score;

    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChanged;

    private void Start()
    {
        _mover = GetComponent<AmogusMover>();
    }

    public void IncreaseScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }

    public void ResetPlayer()
    {
        _score = 0;
        ScoreChanged?.Invoke(_score);
        _mover.ResetAmogus();
    }

    public void Die()
    {
        GameOver?.Invoke();
    }
}
