using UnityEngine;
using UnityEngine.InputSystem;

public class Cube : MonoBehaviour
{
    public Rigidbody2D rb; //Necessari per al moviment d'un objecte
    public float moveSpeed;
    private Vector2 _moveDirection;
    private MeshRenderer myCube;

    public InputActionReference movement; // Refer�ncia a l'acci� que volem utilitzar
    public InputActionReference colorChange;

    private void Start()
    {
        myCube = GetComponent<MeshRenderer>();
    }
    private void OnEnable()
    {
        colorChange.action.performed += ctx => changeColor();
    }
    void Update()
    {
        _moveDirection = movement.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(_moveDirection.x * moveSpeed, _moveDirection.y * moveSpeed);
    }
    void changeColor()
    {
        myCube.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
