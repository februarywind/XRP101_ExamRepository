using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public float MoveSpeed { get; private set; }

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        MoveSpeed = 5f;
    }

    public void MoveSpeedChange(float speed)
    {
        MoveSpeed = speed;
    }
}
