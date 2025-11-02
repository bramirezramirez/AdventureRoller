using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 6f;          // velocidad base
    public float speedIncrease = 0.10f; // incremento por segundo
    public float jumpForce = 8f;

    private Rigidbody rb;
    private int count = 0;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Para saltar
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        // Para reiniciar manualmente
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        // Para reiniciar si caemos por fuera del mapa (Se ha corregido después subiendo los muros)
        if (transform.position.y < -10f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        // Para umentar velocidad de la bolita progresivamente
        speed += speedIncrease * Time.deltaTime;
    }

    void FixedUpdate() //Para crear física al movimiento y mover con W,S,A,D o flechas 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Para poder saltar, detecta que la bolita está tocando Ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        // Si nos pillan se reinicia
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionExit(Collision collision) //Para evitar que nos deje saltar en el aire
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }

    


    // Para contar pickups y actualizar la UI
    public void AddCount(int value)
    {
        count += value;
    }

    public int GetCount()
    {
        return count;
    }
}
