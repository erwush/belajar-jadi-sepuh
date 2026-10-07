using UnityEngine;

public class Gerak : MonoBehaviour
{

    public float spd;
    public Rigidbody2D rb;
    public Vector2 move;

    void Update()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.linearVelocity = move*spd;
    }
}
