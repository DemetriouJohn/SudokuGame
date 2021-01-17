using UnityEngine;

public class GameSettings : MonoBehaviour
{
    private SudokuData _gameData;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        _gameData = new SudokuData();
    }

    private GameMode _gameDifficulty;

    public void SetGameMode(GameMode mode)
    {
        _gameDifficulty = mode;
    }

    public GameMode GetGameMode()
    {
        return _gameDifficulty;
    }

    internal SudokuBoard GetLevel()
    {
        return _gameData.SudokuBoards[_gameDifficulty][0];
    }
}
