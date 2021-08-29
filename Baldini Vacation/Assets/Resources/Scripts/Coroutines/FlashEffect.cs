using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashEffect : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Material defaultMat;
    private Coroutine flashRoutine;
    private float durationTimer;

    [SerializeField]
    private Material flashMat;
    private float flashDuration = 0.1f;
    private float totalDuration = 0.1f;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        defaultMat = sprite.material;
        flashMat = new Material(flashMat);
    }

    public void Flash(Color color)
    {
        if (flashRoutine != null)
        {
            StopCoroutine(flashRoutine);
        }
        flashRoutine = StartCoroutine(FlashRoutine(color));
    }

    private IEnumerator FlashRoutine(Color color)
    {
        durationTimer = totalDuration;
        while (durationTimer >= 0)
        {
            sprite.material = flashMat;

            flashMat.color = color;

            yield return new WaitForSeconds(flashDuration);

            sprite.material = defaultMat;

            yield return new WaitForSeconds(flashDuration);

            durationTimer -= flashDuration * 2;
        }

        flashRoutine = null;
    }
}
