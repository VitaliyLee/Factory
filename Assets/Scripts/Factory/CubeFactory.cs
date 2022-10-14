using UnityEngine;

public class CubeFactory : Factory
{
    //Переопределяем фабричный метод и создаём куб
    public override GameObject Create(GameObject CubePrefab)
    {
        return Object.Instantiate(CubePrefab);
    }
}
