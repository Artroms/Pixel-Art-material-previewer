using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public List<Mesh> meshes;
    public Material material;
    public MeshRenderer meshRenderer;

    public void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        material = meshRenderer.sharedMaterial;
    }

    public void SetMainTexture(Texture2D texture)
    {
        meshRenderer.sharedMaterial.SetTexture("_BaseMap", texture);
    }
    public void SetMetallicMap(Texture texture)
    {
        meshRenderer.sharedMaterial.SetTexture("_MetallicGlossMap", texture);
    }

    public void SetNormalMap(Texture texture)
    {
        meshRenderer.sharedMaterial.SetTexture("_BumpMap", texture);
    }

    public void SetOcclusionMap(Texture texture)
    {
        meshRenderer.sharedMaterial.SetTexture("_OcclusionMap", texture);
    }

    public void SetEmissionMap(Texture texture)
    {
        meshRenderer.sharedMaterial.SetTexture("_EmissionMap", texture);
    }

    public void SetEmissionModifier(float modifier)
    {
        var col = Color.white * modifier;
        meshRenderer.sharedMaterial.SetColor("_EmissionColor", col);
    }

    public void SetSmoothnessModifier(float modifier)
    {
        meshRenderer.sharedMaterial.SetFloat("_Smoothness", modifier);
    }
    public void SetOcclusionModifier(float modifier)
    {
        meshRenderer.sharedMaterial.SetFloat("_OcclusionStrength", modifier);
    }
}
