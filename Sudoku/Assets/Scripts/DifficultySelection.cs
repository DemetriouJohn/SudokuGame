using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelection : MonoBehaviour
{
    private GameSettings _gameSettings;

    private void Awake()
    {
        _gameSettings = FindObjectOfType<GameSettings>();
    }
}
