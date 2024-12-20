using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject ObstacleDesactivar;
    public GameObject ObstacleActivar;

    public void ActivarObstacle()
    {
        ObstacleActivar.SetActive(true);
    }
    public void RestartObstacles()
    {
        ObstacleActivar.SetActive(false);
        ObstacleDesactivar.SetActive(true);
    }
    public void DesactivarObstacle()
    {
        ObstacleDesactivar.SetActive(false);
    }
}
