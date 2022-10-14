using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    [Range(1, 10), Tooltip("Cubes spawn rate in seconds.")]
    [SerializeField] private float _spawnRate;

    [Range(1, 10), Tooltip("Cubes movement speed in meter per second.")]
    [SerializeField] private float _cubeSpeed;

    [Range(1, 20), Tooltip("The distance to which the cubes can move away.")]
    [SerializeField] private int _cubeMovementDistance;

    private CubeController cubeController;
    private SpawnTimer spawnTimer;

    void Start()
    {
        cubeController = new CubeController();
        spawnTimer = new SpawnTimer();

        CubePoller.Warm(_cubePrefab, _cubeMovementDistance);
    }

    private void FixedUpdate()
    {
        cubeController.CubeMovement(_cubeSpeed, _cubeMovementDistance);

        if (spawnTimer.TimeToSpawn(_spawnRate) <= 0)
            CubePoller.SetCubePosition(transform);
    }
}
