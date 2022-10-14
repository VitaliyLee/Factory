using UnityEngine;

public class CubeFactory : Factory
{
    public override GameObject Create(GameObject CubePrefab)
    {
        return Object.Instantiate(CubePrefab);
    }
}
