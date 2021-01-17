using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public delegate void UpdateSquareNumber(byte number);
    public delegate void SquareSelected(byte squareIndex);

    public static event UpdateSquareNumber SquareNumberUpdated;
    public static event SquareSelected SquareSelectedChanged;

    public static void UpdateSquareNumberMethod(byte number)
    {
        SquareNumberUpdated?.Invoke(number);
    }

    public static void SquareSelectedMethod(byte squareIndex)
    {
        SquareSelectedChanged?.Invoke(squareIndex);
    }
}
