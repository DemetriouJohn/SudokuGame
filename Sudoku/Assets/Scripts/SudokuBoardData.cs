public class SudokuBoardData
{
    public byte[] UnsolvedData { get; }
    public byte[] SolvedData { get; }

    public int Level { get; set; }
    public bool Completed { get; set; }

    public SudokuBoardData(byte[] unsolvedData, byte[] solvedData, int level)
    {
        UnsolvedData = unsolvedData;
        SolvedData = solvedData;
        Level = level;
    }
}
