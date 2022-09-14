using UnityEngine;
using UnityEngine.UI;

public class VuforiaManager : MonoBehaviour
{

    [SerializeField]
    private Text searchingText;

    [SerializeField]
    private PointsManager pointsManager;

    [SerializeField]
    private GameObject startButton;

    private bool racketFound;
    private bool boardFound;

    void Update()
    {
        this.ManageSearchingText();
        this.ManageStartButton();
    }

    /* --------------------------------- RACKET --------------------------------- */

    public void SetRacketFound()
    {
        this.racketFound = true;
    }

    public void SetRacketLost()
    {
        this.racketFound = false;
    }

    /* ---------------------------------- BOARD --------------------------------- */

    public void SetBoardFound()
    {
        this.boardFound = true;
    }

    public void SetBoardLost()
    {
        this.boardFound = false;
    }

    /* --------------------------------- HELPERS -------------------------------- */

    private void ManageSearchingText()
    {
        if (racketFound && boardFound)
        {
            this.searchingText.enabled = false;
            return;
        }
        this.searchingText.enabled = true;
    }

    private void ManageStartButton()
    {
        if (!this.pointsManager.GetGameState())
        {

            if (racketFound && boardFound)
            {
                this.startButton.SetActive(true);
                return;
            }
            this.startButton.SetActive(false);
        }
    }
}
