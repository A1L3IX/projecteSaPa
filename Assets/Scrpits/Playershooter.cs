using UnityEngine;
 
public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 1f;
    public float detectionRadius = 8f;
 
    float timer;
 
    void Update()
    {
        timer += Time.deltaTime;
        if (timer < 1f / fireRate) return;
 
        Collider2D enemy = Physics2D.OverlapCircle(transform.position, detectionRadius, LayerMask.GetMask("Enemy"));
        if (enemy == null) return;
 
        timer = 0f;
        Vector2 dir = ((Vector2)enemy.transform.position - (Vector2)transform.position).normalized;
        GameObject b = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        b.GetComponent<Bullet>().Init(dir);
    }
}