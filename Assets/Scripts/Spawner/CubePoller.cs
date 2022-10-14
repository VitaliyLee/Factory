using System.Collections.Generic;
using UnityEngine;

public class CubePoller
{
    private static List<GameObject> cubelList;
    private static int index = 0;
    public static List<GameObject> CubelList => cubelList;

    //Прогрев булера кубов
    public static void Warm(GameObject CubePrefab, int count)
    {
        GameObject cube;
        Factory cubeFactory = new CubeFactory();//Создаём и инициалицируем фабрику для создания кубов
        cubelList = new List<GameObject>();

        //Создаём куб, делаем его неактивным и запихиваем в список
        for (int i = 0; i < count; i++)
        {
            cube = cubeFactory.Create(CubePrefab);
            cube.SetActive(false);
            cubelList.Add(cube);
        }
    }

    //Делаем кубы активными и задаём координаты спавна
    public static void SetCubePosition(Transform SpawnTransform)
    {
        index %= cubelList.Count;

        cubelList[index].gameObject.SetActive(true);

        cubelList[index].transform.position = SpawnTransform.position;

        index++;
    }
}
