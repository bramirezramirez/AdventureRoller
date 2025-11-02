using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    
    public void RestartGame() // Método para reiniciar el juego desde el nivel uno
    {
        SceneManager.LoadScene(0); // Carga el nivel uno
    }

}
