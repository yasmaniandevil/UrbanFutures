using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeGameObject : MonoBehaviour
{
    private GameObject[] _objectsToCycle;
    private int currentIndex = 0;
    private int numObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        _objectsToCycle = GameObject.FindGameObjectsWithTag("ObjectsToCycle");
        numObjects = _objectsToCycle.Length;

        for (int i = 1; i < numObjects; i++)
        {
            SetAlpha(_objectsToCycle[i], 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SetAlpha(_objectsToCycle[currentIndex], 0f);
            Debug.Log("TransparentSpriteNo:" +currentIndex);
            currentIndex = (currentIndex + 1) % numObjects;
            Debug.Log("current index:" + currentIndex);
            SetAlpha(_objectsToCycle[currentIndex], 1f);
            Debug.Log("OpaqueSpriteNo:" +currentIndex);
        }
    }

    private void SetAlpha(GameObject parent, float alpha)
    {
        MeshRenderer[] meshRender = parent.GetComponentsInChildren<MeshRenderer>();
        
            foreach (MeshRenderer meshRenderer in meshRender)
            {
                Color color = meshRenderer.material.color;
                color.a = alpha;
                meshRenderer.material.color = color;
            }

            SpriteRenderer[] spriteRenderers = parent.GetComponentsInChildren<SpriteRenderer>();
            foreach (SpriteRenderer spriteRenderer in spriteRenderers)
            {
                Color color = spriteRenderer.material.color;
                color.a = alpha;
                spriteRenderer.color = color;
            }
        
        Debug.Log("Alpha of " + parent.name + "is now" + alpha);
    }
    
}
