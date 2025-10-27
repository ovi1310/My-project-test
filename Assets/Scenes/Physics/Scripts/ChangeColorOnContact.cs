using UnityEngine;
public class ChangeColorOnContact : MonoBehaviour
{
    private MeshRenderer mycube;
    private void Start()
    {
        mycube = GetComponent<MeshRenderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        randomColor();
    }
    void randomColor()
    {
        mycube.material.color = new Color(Random.value, Random.value, Random.value);
    }
}