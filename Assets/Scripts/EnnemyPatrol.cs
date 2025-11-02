using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] points; // Array de los waypoints
    public float speed = 3f;   // Velocidad del Enemy
    private int destPoint = 0; // Índice actual

    void Update()
    {
        if (points.Length == 0) return;

        // Moverse al waypoint
        Transform target = points[destPoint];
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        // Mirar hacia el objetivo
        transform.LookAt(target);

        // Cuando llegue cambia al siguiente waypoint
        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            destPoint = (destPoint + 1) % points.Length;
        }
    }
}
