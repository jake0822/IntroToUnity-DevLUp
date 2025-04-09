using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class CubeFlasher : MonoBehaviour
{
  public Flash[] cubes;
  public float speed;
  private float timer = 1f;

  private void FixedUpdate()
  {
    if (timer <= 0) 
    {
      cubes[Random.Range(0,cubes.Length-1)].flashCube();
      timer = speed;
    }
    timer -= Time.deltaTime;
  }
}
