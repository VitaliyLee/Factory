using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePoller
{
    private static List<GameObject> cubelList;
    private static int index = 0;
    public static List<GameObject> CubelList => cubelList;

    public static void Warm(GameObject CubePrefab, int count)
    {
        GameObject cube;
        Factory cubeFactory = new CubeFactory();
        cubelList = new List<GameObject>();

        for (int i = 0; i < count; i++)
        {
            cube = cubeFactory.Create(CubePrefab);
            cube.SetActive(false);
            cubelList.Add(cube);
        }
    }

    public static void SetCubePosition(Transform SpawnTransform)
    {
        index %= cubelList.Count;

        cubelList[index].gameObject.SetActive(true);

        cubelList[index].transform.position = SpawnTransform.position;

        index++;
    }
}
