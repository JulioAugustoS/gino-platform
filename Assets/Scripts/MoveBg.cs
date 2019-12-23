using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBg : MonoBehaviour {
    public float speed = 1.0f;

    // Update is called once per frame
    void Update() {
        Vector2 offset = new Vector2(Time.time * speed, 0f);
        gameObject.GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
