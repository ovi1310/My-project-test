using UnityEngine;

public class Mission : MonoBehaviour
{
    public void NewMission(int points)
    {
        if (points < 420)
        {
            Debug.Log("I'm too weak");
        }
        else
        {
            Debug.Log("Let's go!");
        }
    }
}
