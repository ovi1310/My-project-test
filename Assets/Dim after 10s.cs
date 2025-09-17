using UnityEngine;

public class Dimafter10s : MonoBehaviour
{
    [Header("Configuraci�n de atenuaci�n")]
    public float fadeDuration = 5f; // Duraci�n de la atenuaci�n
    public float targetIntensity = 0f; // Intensidad objetivo
    public float startDelay = 10f; // Tiempo antes de empezar (10 segundos)

    private Light pointLight;
    private float originalIntensity;
    private float timer = 0f;
    private bool shouldFade = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Obtener el componente Light
        pointLight = GetComponent<Light>();

        if (pointLight != null)
        {
            originalIntensity = pointLight.intensity;
        }
        else
        {
            Debug.LogError("No se encontr� el componente Light en este GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!shouldFade)
        {
            // Esperar el delay inicial
            timer += Time.deltaTime;
            if (timer >= startDelay)
            {
                shouldFade = true;
                timer = 0f; // Resetear timer para el fade
            }
            return;
        }

        if (pointLight != null && shouldFade)
        {
            // Realizar el fade
            timer += Time.deltaTime;
            float progress = Mathf.Clamp01(timer / fadeDuration);

            pointLight.intensity = Mathf.Lerp(originalIntensity, targetIntensity, progress);

            // Detener cuando termine el fade
            if (progress >= 1f)
            {
                enabled = false; // Desactivar el script
            }
        }
    }
}
