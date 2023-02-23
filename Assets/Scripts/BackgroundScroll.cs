using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 0.5f;
    private MeshRenderer meshRen;

    private void Awake()
    {
        meshRen = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        Vector2 offset = meshRen.sharedMaterial.GetTextureOffset("_MainTex");
        offset.y += Time.deltaTime * scrollSpeed;

        meshRen.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
} 
