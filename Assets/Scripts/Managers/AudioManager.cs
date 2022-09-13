using UnityEngine;

public class AudioManager : MonoBehaviour
{

    #region Singleton

    private static AudioManager instance;

    private void Awake()
    {
        instance = this;
    }

    public static AudioManager GetInstance()
    {
        return instance;
    }

    #endregion

    [SerializeField]
    private AudioSource menuItemHover;

    [SerializeField]
    private AudioSource bounce;

    [SerializeField]
    private AudioSource lose;

    [SerializeField]
    private AudioSource ballOut;

    [SerializeField]
    private AudioSource score;

    [SerializeField]
    private AudioSource respawn;

    [SerializeField]
    private AudioSource wall;

    [SerializeField]
    private AudioSource win;

    [SerializeField]
    private AudioSource rolling;


    public void PlayMenuItemHover()
    {
        menuItemHover.Play();
    }

    public void PlayBounce()
    {
        bounce.Play();
    }

    public void PlayLose()
    {
        lose.Play();
    }

    public void PlayBallOut()
    {
        ballOut.Play();
    }

    public void PlayScore()
    {
        score.Play();
    }

    public void PlayRespawn()
    {
        respawn.Play();
    }

    public void PlayWall()
    {
        wall.Play();
    }

    public void PlayWin()
    {
        win.Play();
    }

    public void PlayRolling()
    {
        rolling.Play();
    }
}
