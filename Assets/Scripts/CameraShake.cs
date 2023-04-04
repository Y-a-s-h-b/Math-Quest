using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public bool start = false;
    public AnimationCurve curve;
    public float duration = 1f;

    
    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            start = false;
            StartCoroutine(Shaking());
        }
    }

    IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position;
        float elaspedTime = 0f;

        while (elaspedTime<duration)
        {
            elaspedTime += Time.deltaTime;
            float strength = curve.Evaluate(elaspedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength;
            yield return null;

        }

        transform.position = startPosition;
    }
}
