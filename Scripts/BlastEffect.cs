using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastEffect : MonoBehaviour
{
    public float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyItSelf());
    }


    IEnumerator DestroyItSelf()// destroyed it self after 0.5 seconds;
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
