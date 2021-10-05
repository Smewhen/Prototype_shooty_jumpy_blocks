using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    private World world;
    public Transform rocket;

    void Start () {
        world = GameObject.Find ("World").GetComponent<World> ();
    }
    
    void Update () {
        RocketCollision ();
    }

    private void RocketCollision () {
        if (
            world.CheckForVoxel (rocket.position)
            ) {
            Debug.Log ("Explosion");
            world.GetChunkFromVector3 (rocket.position).EditVoxel (rocket.position, 0);
            Destroy (gameObject, 0.01f);
        } else
            Debug.Log ("Miss");
            Destroy (gameObject, 2f);
    }
}
