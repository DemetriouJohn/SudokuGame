using System.Collections.Generic;
using UnityEngine;
public class GameGrid : MonoBehaviour
{
    public int Columns = 0;
    public int Rows = 0;
    public float SquareOffset = 0f;
    public GameObject GridSquareObject;
    public Vector2 StartPosition = new Vector2(0f, 0f);
    public float SquareScale = 1f;

    private List<GameObject> GridSquareObjects = new List<GameObject>();
    private GameSettings _gameSettings;

    private void Awake()
    {
        _gameSettings = FindObjectOfType<GameSettings>();
    }

    private void Start()
    {
        if (GridSquareObject.GetComponent<GridSquare>() == null)
        {
            Debug.LogError("Error");
        }

        CreateGrid();
        SetGridNumbers();
    }

    private void CreateGrid()
    {
        SpawnGridSquares();
        SetSquarePositions();
    }

    private void SpawnGridSquares()
    {
        byte index = 0;
        for (int row = 0; row < Rows; row++)
        {
            for (int column = 0; column < Columns; column++)
            {
                var square = Instantiate(GridSquareObject);
                square.GetComponent<GridSquare>().SetSquareIndex(index);
                index++;
                square.transform.SetParent(transform);
                square.transform.localScale = new Vector3(SquareScale, SquareScale, SquareScale);
                GridSquareObjects.Add(square);
            }
        }
    }

    private void SetGridNumbers()
    {
        var data = _gameSettings.GetLevel();
        for (var i = 0; i < GridSquareObjects.Count; i++)
        {
            GridSquareObjects[i].GetComponent<GridSquare>().SetNumber(data.UnsolvedData[i]);
        }
    }

    private void SetSquarePositions()
    {
        var squareRect = GridSquareObjects[0].GetComponent<RectTransform>();
        var offset = new Vector2
        {
            x = squareRect.rect.width * squareRect.transform.localScale.x + SquareOffset,
            y = squareRect.rect.height * squareRect.transform.localScale.y + SquareOffset,
        };

        int columnNum = 0;
        int rowNum = 0;

        foreach (var square in GridSquareObjects)
        {
            if (columnNum + 1 > Columns)
            {
                rowNum++;
                columnNum = 0;
            }

            var posXOffset = offset.x * columnNum;
            var posYOffset = offset.y * rowNum;
            square.GetComponent<RectTransform>().anchoredPosition = new Vector2(StartPosition.x + posXOffset, StartPosition.y - posYOffset);
            columnNum++;
        }
    }
}