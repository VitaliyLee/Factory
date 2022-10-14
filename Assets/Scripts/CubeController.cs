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
        //Передвижение каждого куба в булере поочереди
        for (int i = 0; i < CubePoller.CubelList.Count; i++)
        {
            cubeTransform = CubePoller.CubelList[i].transform;

            //Если куб привысил максимальное расстояние для движения, то он становиться неактивным
            if (cubeTransform.position.magnitude >= MovementDistance)
                CubePoller.CubelList[i].SetActive(false);

            movement.Move(Speed, cubeTransform);//Передвижение куба
        }
    }
}
