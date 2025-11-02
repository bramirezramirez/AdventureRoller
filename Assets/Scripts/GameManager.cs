using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int totalPickups;              
    public TMP_Text countText;            
    public TMP_Text winText;              
    public PlayerController player;       

    private bool levelCompleted = false;  // Para no disparar LevelCompleted más de una vez por nivel

    void Start()
    {
        // Oculta el texto de victoria al empezar
        if (winText != null)
            winText.gameObject.SetActive(false);

        // Inicializar conteo
        UpdateCountText();
    }

    void Update() // Para comprobar si hemos completado el nivel
    {
        if (!levelCompleted && player != null && player.GetCount() >= totalPickups)
        {
            LevelCompleted();
        }

        // Actualiza el texto en tiempo real
        if (player != null)
            UpdateCountText();
    }

    public void UpdateCountText() // Para que vaya actualizando los puntos
    {
        if (countText != null && player != null)
            countText.text = "Puntos: " + player.GetCount() + " / " + totalPickups;
    }

    void LevelCompleted()
    {
        levelCompleted = true;

        if (winText != null)
        {
            winText.gameObject.SetActive(true);
            winText.text = "¡Nivel superado, toma ya!";
        }

        // Para que espere dos segundos y carga el siguiente nivel
        Invoke(nameof(NextLevel), 2f);
    }

    void NextLevel() //Para calcular la siguiente escena en el Build Profiles, si la hay salta al siguiente nivel, si no pues salta al GameEnd
    {
        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextIndex < SceneManager.sceneCountInBuildSettings)
        {
            
            SceneManager.LoadScene(nextIndex);
        }
        else
        {
            SceneManager.LoadScene("GameEnd");
        }
    }
    
}
