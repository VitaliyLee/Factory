using UnityEngine;

public class CubeController
{
    private Movement movement;
    private Transform cubeTransform;

    public CubeController()
    {
        movement = new Movement();
    }

    public void CubeMovement(float Speed, int MovementDistance)
    {
        for (int i = 0; i < CubePoller.CubelList.Count; i++)
        {
            cubeTransform = CubePoller.CubelList[i].transform;

            if (cubeTransform.position.magnitude >= MovementDistance)
                CubePoller.CubelList[i].SetActive(false);

            movement.Move(Speed, cubeTransform);
        }
    }
}
