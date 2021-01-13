using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEmissionTexture : TextureFinder
{
    protected override void ApplyTexture()
    {
        mc.SetEmissionMap(texture);
    }
}
