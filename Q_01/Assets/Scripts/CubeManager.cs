using UnityEngine;

public class CubeManager : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    private CubeController _cubeController;

    private void Start()
    {
        CreateCube();
    }

    private void CreateCube()
    {
        GameObject cube = Instantiate(_cubePrefab);

        _cubeController = cube.GetComponent<CubeController>();

        _cubeController.SetPosition(new Vector3(3, 0, 3));
    }
}
