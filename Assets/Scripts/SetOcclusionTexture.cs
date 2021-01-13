using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOcclusionTexture : TextureFinder
{
    protected override void ApplyTexture()
    {
        mc.SetOcclusionMap(texture);
    }
}
