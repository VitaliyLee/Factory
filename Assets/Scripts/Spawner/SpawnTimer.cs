using UnityEngine;

public class SpawnTimer
{
    private float timeToSpawn;

    public float TimeToSpawn(float SpawnRate)
    {
        if (timeToSpawn <= 0)
            timeToSpawn = SpawnRate;

        timeToSpawn -= Time.fixedDeltaTime;

        return timeToSpawn;
    }
}
