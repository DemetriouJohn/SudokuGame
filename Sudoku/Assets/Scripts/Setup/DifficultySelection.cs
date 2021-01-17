using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelection : MonoBehaviour
{
    private GameSettings _gameSettings;

    private void Awake()
    {
        _gameSettings = FindObjectOfType<GameSettings>();
    }

    public void DifficultySelectButtonClick(int difficulty)
    {
        _gameSettings.SetGameMode((GameMode)difficulty);
        SceneManager.LoadScene("GameScene");
    }
}
