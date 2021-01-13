using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMainTexture : TextureFinder
{
    protected override void ApplyTexture()
    {
        mc.SetMainTexture(texture);
    }
}
