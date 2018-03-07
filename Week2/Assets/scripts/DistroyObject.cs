using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistroyObject : MonoBehaviour {

	public void DestroyThis()
    {
        Destroy(this.gameObject);
    }
}
