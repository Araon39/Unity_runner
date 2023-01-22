using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefabObstacles;
    [SerializeField] private Vector3 _positionObstacles;

    void Start()
    {
        InvokeRepeating(nameof(SpawnerObstacles), 3, 3);
    }

    

    private void SpawnerObstacles()
    {
        GameObject obstacle = Instantiate(_prefabObstacles);
        obstacle.transform.position = _positionObstacles;
    }
}
