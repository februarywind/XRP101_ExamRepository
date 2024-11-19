using UnityEngine;

public class ObjectRotater : MonoBehaviour
{
    // 팝업 출력중 메인으로 이동시 초기화 되도록
    private void OnEnable()
    {
        GameManager.Intance.IsPause = false;
    }
    private void Update()
    {
        transform.Rotate(Vector3.up * GameManager.Intance.Score * Time.timeScale * (GameManager.Intance.IsPause ? 0 : 1));
    }
}
