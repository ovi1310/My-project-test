using UnityEngine;
public class Spawner1 : MonoBehaviour
{
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;
    public Transform spawnPoint;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnSphere();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SpawnCylinder();
        }
    }

    void SpawnSphere()
    {
        Vector3 position = spawnPoint ? spawnPoint.position : transform.position;
        Instantiate(spherePrefab, position, Quaternion.identity);
    }

    void SpawnCylinder()
    {
        Vector3 position = spawnPoint ? spawnPoint.position : transform.position;
        Instantiate(cylinderPrefab, position, Quaternion.identity);
    }
}
