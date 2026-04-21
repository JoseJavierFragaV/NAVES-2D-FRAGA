using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Captura input de las flechas
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Normalizar para evitar que vaya m�s r�pido en diagonal
        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        // Movimiento con f�sicas
        rb.linearVelocity = movement * speed;
    }
}