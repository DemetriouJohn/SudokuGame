
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public GameSettings Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }

        DontDestroyOnLoad(this);
        Instance = this;
    }

    private GameMode _gameMode;

    public void SetGameMode(GameMode mode)
    {
        _gameMode = mode;
    }

    public string GetGameMode()
    {
        return _gameMode.ToString();
    }
}
