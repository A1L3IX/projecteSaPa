using UnityEngine;
using UnityEngine.InputSystem;
 
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
 
    Rigidbody2D rb;
 
    void Awake() => rb = GetComponent<Rigidbody2D>();
 
    void Update()
    {
        Vector2 input = Keyboard.current != null
            ? new Vector2(
                (Keyboard.current.dKey.isPressed ? 1 : 0) - (Keyboard.current.aKey.isPressed ? 1 : 0),
                (Keyboard.current.wKey.isPressed ? 1 : 0) - (Keyboard.current.sKey.isPressed ? 1 : 0))
            : Vector2.zero;
 
        rb.linearVelocity = input.normalized * moveSpeed;
    }
}