using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMetallicTexture : TextureFinder
{
    protected override void ApplyTexture()
    {
        mc.SetMetallicMap(texture);
    }
}
