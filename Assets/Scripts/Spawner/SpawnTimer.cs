using UnityEngine;

public class SpawnTimer
{
    private float timeToSpawn;

    //Вычисление времени до появления нового куба
    public float TimeToSpawn(float SpawnRate)
    {
        if (timeToSpawn <= 0)
            timeToSpawn = SpawnRate;

        timeToSpawn -= Time.fixedDeltaTime;

        return timeToSpawn;
    }
}
