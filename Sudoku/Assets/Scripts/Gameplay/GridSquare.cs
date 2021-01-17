using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class GridSquare : Selectable, IPointerClickHandler, ISubmitHandler, IPointerUpHandler, IPointerExitHandler
{
    private byte _number;
    private bool _selected = false;
    private byte _squareIndex;

    public GameObject NumberText;

    public bool IsSelected => _selected;
    public void SetSquareIndex(byte index)
    {
        _squareIndex = index;
    }

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

    public void OnPointerClick(PointerEventData eventData)
    {
        _selected = true;
        GameEvents.SquareSelectedMethod(_squareIndex);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    protected override void OnEnable()
    {
        GameEvents.SquareNumberUpdated += OnUpdateSquareNumber;
        GameEvents.SquareSelectedChanged += OnSquareSelectedChanged;
        base.OnEnable();
    }
    protected override void OnDisable()
    {
        GameEvents.SquareSelectedChanged -= OnSquareSelectedChanged;
        GameEvents.SquareNumberUpdated -= OnUpdateSquareNumber;
        base.OnDisable();
    }

    private void OnSquareSelectedChanged(byte squareIndex)
    {
        _selected = squareIndex == _squareIndex;
    }

    private void OnUpdateSquareNumber(byte number)
    {
        if (_selected)
        {
            SetNumber(number);
        }
    }
}
