using System.Collections;
using System.Collections.Generic;
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
    private AudioSource menuOption;

    [SerializeField]
    private AudioSource menuTheme;

    [SerializeField]
    private AudioSource bounce;

    [SerializeField]
    private AudioSource lose;

    [SerializeField]
    private AudioSource ballTest;

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

    public void PlayMenuOption()
    {
        menuOption.Play();
    }

    public void PlayTheme()
    {
        menuTheme.Play();
    }

    public void PlayBounce()
    {
        bounce.Play();
    }

    public void PlayLose()
    {
        lose.Play();
    }

    public void PlayOut()
    {
        ballTest.Play();
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
