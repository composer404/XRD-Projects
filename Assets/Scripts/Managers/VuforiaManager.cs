using UnityEngine;
using UnityEngine.UI;

public class VuforiaManager : MonoBehaviour
{

    [SerializeField]
    private Text searchingText;

    private bool racketFound;
    private bool boardFound;

    void Update()
    {
        this.ManageSearchingText();
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
            searchingText.enabled = false;
            return;
        }
        searchingText.enabled = true;
    }
}
