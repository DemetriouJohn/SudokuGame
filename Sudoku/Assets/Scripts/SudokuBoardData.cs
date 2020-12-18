public struct SudokuBoardData
    {
        public byte[] UnsolvedData { get; }
        public byte[] SolvedData { get; }

        public SudokuBoardData(byte[] unsolvedData, byte[] solvedData)
        {
            UnsolvedData = unsolvedData;
            SolvedData = solvedData;
        }
    }
