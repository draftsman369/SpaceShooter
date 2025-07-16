using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] Transform[] firePoints;
    [SerializeField] float fireRate = 0.2f;
    private float fireTimer;

    void Update()
    {
        fireTimer -= Time.deltaTime;
        if (fireTimer <= 0f)
        {
            Fire();
            fireTimer = fireRate;
        }
    }

    void Fire()
    {
        foreach (var point in firePoints)
        {
            GameObject bullet = BulletPool.Instance.GetBullet();
            bullet.transform.position = point.position;
            bullet.transform.rotation = point.rotation;
        }
    }
}
