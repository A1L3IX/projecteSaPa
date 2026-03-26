using UnityEngine;
 
[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 10;
 
    public void Init(Vector2 dir)
    {
        GetComponent<Rigidbody2D>().linearVelocity = dir * speed;
        Destroy(gameObject, 3f);
    }
 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy")) return;
        Destroy(gameObject);
    }
}
 