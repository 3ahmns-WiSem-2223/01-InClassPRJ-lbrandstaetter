using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameManager.counter++;
            TargetSpawner.targetCount--;
            Destroy(gameObject);
        }
    }
}