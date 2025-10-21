using UnityEngine;
using UnityEngine.InputSystem;

public class Cube : MonoBehaviour
{
    public Rigidbody2D rb; //Necessari per al moviment d'un objecte
    public float moveSpeed;
    private Vector2 _moveDirection;

    public InputActionReference movement; // Referència a l'acció que volem utilitzar
    public InputActionReference colorChange;

    void Update()
    {
        _moveDirection = movement.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(_moveDirection.x * moveSpeed, _moveDirection.y * moveSpeed);
    }
}
