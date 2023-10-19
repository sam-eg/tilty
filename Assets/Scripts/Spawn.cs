using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject fallBallPrefab;
    public int fallBallCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fallBallCount = FindObjectsOfType<FallBall>().Length;

        if (fallBallCount == 0)
        {
            Instantiate(fallBallPrefab, GenerateSpawnPosition(), fallBallPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        Vector2 randomCircleLocation = Random.insideUnitCircle * 12;
        return new Vector3(randomCircleLocation.x, 10, randomCircleLocation.y);
    }
}
