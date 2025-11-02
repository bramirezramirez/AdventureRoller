using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Follow Target")]  
    public Transform player; // Para seguir la bolita

    [Header("Camera Offset & Smoothness")]
    public Vector3 offset = new Vector3(0, 8f, -10f); // Para controlar el desplazamiento de la camara
    public float smoothSpeed = 0.15f; //La suavidad

    [Header("Look Settings")] //Para controlar el enfoque de la cámara y que no se quede apuntando al suelo directamente
    public bool lookAtPlayer = true;
    public Vector3 lookOffset = new Vector3(0, 2f, 0f);

    void LateUpdate()  //Para asegurar que la cámara se mueva después de que la bolita empiezce a moverse
    {
        if (player == null) return;

        // Posición deseada con desplazamiento
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // AplicarAplica la posición
        transform.position = smoothedPosition;

        // La cámara gira automáticamente para ver la bolita
        if (lookAtPlayer)
        {
            transform.LookAt(player.position + lookOffset);
        }
    }
}
