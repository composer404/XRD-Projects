using TMPro;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI leftText;

    [SerializeField]
    private TextMeshProUGUI rightText;

    [SerializeField]
    private BallController ballController;

    [SerializeField]
    private GameObject finalDialog;

    [SerializeField]
    private GameObject congratsText;

    [SerializeField]
    private GameObject gameOverText;

    [SerializeField]
    private int pointsToWin = 1;

    private bool win;

    private int _leftPoints = 0;
    private int _rightPoints = 0;
    private bool gameStarted;

    public void AddLeftPoint()
    {
        _leftPoints++;
        leftText.text = _leftPoints.ToString();

        if (_leftPoints >= this.pointsToWin)
        {
            this.finalDialog.SetActive(true);
            this.gameOverText.SetActive(true);
            this.congratsText.SetActive(false);
            Finish();
        }
    }
    public void AddRightPoint()
    {
        _rightPoints++;
        rightText.text = _rightPoints.ToString();

        if (_rightPoints >= this.pointsToWin)
        {
            this.finalDialog.SetActive(true);
            this.congratsText.SetActive(true);
            this.gameOverText.SetActive(false);
            Finish();
        }
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

    public bool GetWin()
    {
        return win;
    }

    private void Finish()
    {
        this.win = true;
        this.finalDialog.SetActive(true);
        this.gameOverText.SetActive(true);
        this.StopGame();
    }

}
