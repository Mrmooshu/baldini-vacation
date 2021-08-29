using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashEffect : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Material defaultMat;
    private Coroutine flashRoutine;

    [SerializeField]
    private Material flashMat;

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
        sprite.material = flashMat;

        flashMat.color = color;

        yield return new WaitForSeconds(0.05f);

        sprite.material = defaultMat;

        flashRoutine = null;
    }
}
