using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI conteoText;  // o TextMeshProUGUI si usas TextMeshPro
    public GameObject gameOverPanel;
    private int conteo = 0;
    private int maxExplosiones = 3;
    void Start()
    {
        conteoText.text = "Explosiones: 0";
        gameOverPanel.SetActive(false);   
    }
    public void RegistrarExplosion()
    {
        conteo++;
        conteoText.text = "Explosiones: " + conteo;

        if (conteo >= 3)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
