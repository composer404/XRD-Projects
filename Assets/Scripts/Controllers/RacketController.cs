using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour
{

    [SerializeField]
    private float speed = 0.01f;

    [SerializeField]
    private GameObject bottomWall;

    [SerializeField]
    private GameObject topWall;

    void Start() { }

    void Update()
    {

    }

    void FixedUpdate()
    {
        DetectDirection();
        this.transform.position += new Vector3(speed, 0, 0);
    }

    private void DetectDirection()
    {
        float bottomX = this.gameObject.transform.position.x - (this.gameObject.GetComponent<Collider>().bounds.size.x / 2);
        float topX = this.gameObject.transform.position.x + (this.gameObject.GetComponent<Collider>().bounds.size.x / 2);
        if (bottomX <= this.bottomWall.transform.position.x || topX >= this.topWall.transform.position.x)
        {
            this.speed = -this.speed;
            AudioManager.GetInstance().PlayWall();
        }
    }
}
