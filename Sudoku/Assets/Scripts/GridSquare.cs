using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GridSquare : Selectable
{
    private byte _number;
    public GameObject NumberText;

    public void SetNumber(byte number)
    {
        _number = number;
        DisplayText();
    }

    public void DisplayText()
    {
        var txt = NumberText.GetComponent<Text>();
        txt.text = _number <= 0 ? " " : _number.ToString();
    }
}
