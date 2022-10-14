using UnityEngine;

public class Movement
{
    private Vector3 moveDirection;

    public Movement()
    {
        moveDirection = Vector3.forward;
    }
    public void Move(float Speed, Transform CurrentTransform)
    {
        CurrentTransform.position += moveDirection * Speed * Time.fixedDeltaTime;
    }
}
