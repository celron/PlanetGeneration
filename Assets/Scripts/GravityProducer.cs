﻿using UnityEngine;
using System.Collections;

public class GravityProducer : MonoBehaviour {
    public static readonly float G = 0.001f;
    public float mass;

    public Vector3 Center { get { return transform.position; } }
}
