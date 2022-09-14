using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private PointsManager pointsManager;

    private float speed;
    private Rigidbody rb;
    private Vector3 startPosition;

    void Start()
    {
        this.speed = (PlayerPrefs.GetFloat(PrefsEnumClass.BALL_SPEED) / 100) * 10;
        if (this.speed == 0)
        {
            this.speed = 0.5f;
        }
        this.rb = gameObject.GetComponent<Rigidbody>();
        this.startPosition = gameObject.transform.position;
    }

    public void StartGame()
    {
        if (!this.pointsManager.GetGameState())
        {
            this.pointsManager.StartGame();
        }
        this.rb.velocity = GenerateStartDirection();
    }

    void Update()
    { }

    public void Spawn()
    {
        gameObject.transform.position = this.startPosition;
        this.rb.velocity = new Vector3(0, 0, 0);
        AudioManager.GetInstance().PlayRespawn();
    }

    public void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;

        this.VerifyLimiter(tag);
        this.VerifyPoint(tag);
    }

    private void VerifyPoint(string tag)
    {
        if (tag == TagEnumClass.LEFT_STOP_WALL || tag == TagEnumClass.RIGHT_STOP_WALL)
        {
            if (tag == TagEnumClass.LEFT_STOP_WALL)
            {
                pointsManager.AddRightPoint();
                print("Right point");
            }

            if (tag == TagEnumClass.RIGHT_STOP_WALL)
            {
                pointsManager.AddLeftPoint();
                print("left point");
            }
            if (this.CheckWin())
            {
                return;
            }
            Spawn();
            StartGame();
        }
    }

    private bool CheckWin()
    {
        if (this.pointsManager.GetWin())
        {
            this.StopBall();
            return true;
        }
        return false;
    }

    private void StopBall()
    {
        this.rb.velocity = Vector3.zero;
        this.rb.angularVelocity = Vector3.zero;
        gameObject.transform.position = this.startPosition;
    }

    private void VerifyLimiter(string tag)
    {
        if (tag == TagEnumClass.LIMITER)
        {
            Spawn();
            StartGame();
        }
    }

    private Vector3 GenerateStartDirection()
    {
        float startXDirection = Random.Range(0, 2) == 0 ? -1 : 1;
        float startZDirection = Random.Range(0, 2) == 0 ? -1 : 1;

        return new Vector3(startXDirection * speed, 0f, startZDirection * speed);
    }
}
