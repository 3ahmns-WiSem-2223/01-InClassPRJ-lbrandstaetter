using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] GameObject targetPrefab;
    public static int targetCount;

    private void Update()
    {
        Vector3 randomPos = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0);

        if (targetCount < 3)
        {
            Instantiate(targetPrefab, randomPos, Quaternion.identity);
            targetCount++;
        }
    }
}