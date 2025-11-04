using UnityEngine;
using System.Collections;
public class ColorCircle : MonoBehaviour
{
    public GameObject[] spheres;
    private int index;
    void Start()
    {
        index = 0;
    }
    private void Update()
    {
        Invoke("iterate", 1f);
        if (index < 6)
        {
            index += 1;
        }
        else
        {
            index = 0;
        }
    }
    void iterate()
    {
            for (int i = 0; i < spheres.Length; i++)
            {
                spheres[i].GetComponent<Renderer>().material.color = Color.white;
            }
            spheres[index].GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("Sphere" + index + "red");
    }
}
