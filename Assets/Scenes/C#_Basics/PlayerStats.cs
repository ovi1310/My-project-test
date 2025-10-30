using UnityEngine;

public class Playerstats : MonoBehaviour
{
    public Mission mission;
    public int xp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mission = GetComponent<Mission>();
        xp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        mission.NewMission(xp);
    }
}
