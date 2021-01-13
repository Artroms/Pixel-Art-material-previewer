using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNormalTexture : TextureFinder
{
    protected override void ApplyTexture()
    {
        mc.SetNormalMap(texture);
    }
}
