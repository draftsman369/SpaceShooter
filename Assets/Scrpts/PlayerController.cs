using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;


    Vector2 velocity;
    [SerializeField] float speed = 5f;
    [SerializeField] float minX = -5f;
    [SerializeField] float maxX = 5f;
    [SerializeField] float minY = -3f;
    [SerializeField] float maxY = 3f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.linearVelocity = InputReader.Instance.MoveInput * speed;
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;

    }
}
