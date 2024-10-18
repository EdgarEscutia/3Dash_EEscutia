using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject Obstacle;

    public void ActivarObstacle()
    {
        Obstacle.SetActive(true);
        Debug.Log("ACCTTTTIIIVVVAAAAADOOOOOOOOOO");
    }
    public void DesactivarObstacle()
    {
        Obstacle.SetActive(false);
        Debug.Log("DESACCCCCCCCCCCCTIVAAAAADDDOOOOOOO");
    }
}
