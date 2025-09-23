using UnityEngine;

public class Crazy_disco : MonoBehaviour
{
    private Light crazyDisco;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        crazyDisco = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        crazyDisco.color = new Color(Random.value, Random.value, Random.value);
    }
}
