using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;


    Rigidbody rb;
    Vector3 startPosition;

    void Start()
    {
        this.rb = gameObject.GetComponent<Rigidbody>();
        this.startPosition = gameObject.transform.position;
    }

    //! HERE IT SHOULD BE A BUTTON ON A SCREEN TO START GAME AND ADD VELOCITY AND APPEARS AGAIN AFTER EACH POINT
    void OnMouseDown()
    {
        this.rb.velocity = GenerateStartDirection();
        AudioManager.GetInstance().PlayRolling();
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
        if (tag == TagEnumClass.LEFT_STOP_WALL)
        {
            //! HERE WE NEED TO ADD POINTS USING "PointsManager"
            print("Right point");
        }

        if (tag == TagEnumClass.RIGHT_STOP_WALL)
        {
            //! HERE WE NEED TO ADD POINTS USING "PointsManager"
            print("left point");
        }
        Spawn();
    }

    private Vector3 GenerateStartDirection()
    {
        float startXDirection = Random.Range(0, 2) == 0 ? -1 : 1;
        float startZDirection = Random.Range(0, 2) == 0 ? -1 : 1;

        return new Vector3(startXDirection * speed, 0f, startZDirection * speed);
    }
}
