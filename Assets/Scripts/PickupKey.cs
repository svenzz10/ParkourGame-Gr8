using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : MonoBehaviour
{
    private void OnTriggerEnter(Collider  other){
        Objectivescore.KeysFound += 1;
        Destroy(this.gameObject);
    }
}
