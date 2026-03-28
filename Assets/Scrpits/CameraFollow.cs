using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public Transform player;

    
    public float smoothSpeed = 5f;

    
    public float minX, maxX, minY, maxY;

    void LateUpdate()
    {
        Vector3 objetivo = new Vector3(player.position.x, player.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, objetivo, smoothSpeed * Time.deltaTime);

        float clampX = Mathf.Clamp(transform.position.x, minX, maxX);
        float clampY = Mathf.Clamp(transform.position.y, minY, maxY);
        transform.position = new Vector3(clampX, clampY, transform.position.z);
    }
}