using UnityEngine;

public class ObjectRotater : MonoBehaviour
{
    // �˾� ����� �������� �̵��� �ʱ�ȭ �ǵ���
    private void OnEnable()
    {
        GameManager.Intance.IsPause = false;
    }
    private void Update()
    {
        transform.Rotate(Vector3.up * GameManager.Intance.Score * Time.timeScale * (GameManager.Intance.IsPause ? 0 : 1));
    }
}
