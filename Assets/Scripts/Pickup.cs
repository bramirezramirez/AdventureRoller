using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int value = 1; // puntos que da el pickup

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Debug que estabiliza el trigger, lo he dejado por un error que me llevo una hora resolver... me contaba doble punto por tener AddCount en dos archivos...
            Debug.Log("Trigger con pickup: " + gameObject.name + " | Time: " + Time.time);

            // Para sumar los puntos al PlayerController
            PlayerController pc = other.GetComponent<PlayerController>();
            if (pc != null)
            {
                pc.AddCount(value);
                FindObjectOfType<GameManager>().UpdateCountText(); // Para actualizar la UI
            }

            // Adios al pickup
            Destroy(gameObject);
        }
    }
}
