using UnityEngine;
 
public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float detectionRadius = 8f;
    public float fireRate = 1f;
 
    float timer;
 
    void Update()
    {
        timer += Time.deltaTime;
        if (timer < 1f / fireRate) return;
 
        GameObject nearest = FindNearestEnemy();
        if (nearest == null) return;
 
        timer = 0f;
        Vector2 dir = ((Vector2)nearest.transform.position - (Vector2)transform.position).normalized;
        GameObject b = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        b.GetComponent<Bullet>().Init(dir);
    }
 
    GameObject FindNearestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject nearest = null;
        float minDist = detectionRadius;
 
        foreach (GameObject e in enemies)
        {
            float dist = Vector2.Distance(transform.position, e.transform.position);
            if (dist < minDist)
            {
                minDist = dist;
                nearest = e;
            }
        }
 
        return nearest;
    }
}
 