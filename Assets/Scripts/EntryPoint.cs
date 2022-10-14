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
    private int warmPoolerCount = 20; //Максимальное колличество кубов в пулере (должно быть равно максимальному ренджу дистанции для куба)

    void Start()
    {
        cubeController = new CubeController();
        spawnTimer = new SpawnTimer();

        CubePoller.Warm(_cubePrefab, warmPoolerCount);//Прогрев пулера
    }

    private void FixedUpdate()
    {
        cubeController.CubeMovement(_cubeSpeed, _cubeMovementDistance);//Передвижение кубов

        if (spawnTimer.TimeToSpawn(_spawnRate) <= 0)//Проверка на то, сколько времени до появления нового куба
            CubePoller.SetCubePosition(transform);
    }
}
