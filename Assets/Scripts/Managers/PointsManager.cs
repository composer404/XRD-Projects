using TMPro;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI leftText;

    [SerializeField]
    private TextMeshProUGUI rightText;

    private int _leftPoints = 0;
    private int _rightPoints = 0;
    private bool gameStarted;

    public void AddLeftPoint()
    {
        _leftPoints++;
        leftText.text = _leftPoints.ToString();
    }
    public void AddRightPoint()
    {
        _rightPoints++;
        rightText.text = _rightPoints.ToString();
    }

    public void StartGame()
    {
        this.gameStarted = true;
    }

    public void StopGame()
    {
        this.gameStarted = false;
    }

    public bool GetGameState()
    {
        return this.gameStarted;
    }

    public void Reset()
    {
        _leftPoints = 0;
        _rightPoints = 0;
        leftText.text = "0";
        rightText.text = "0";
    }

}
