using UnityEngine;

public class UserRacketController : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    private float startY;
    private float startZ;

    void Start()
    {
        this.startY = gameObject.transform.position.y;
        this.startZ = gameObject.transform.position.z;
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            gameObject.transform.position = new Vector3(target.transform.position.x, this.startY, this.startZ);
        }
    }
}
