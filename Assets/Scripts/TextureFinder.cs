using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using SimpleFileBrowser;
using UnityEngine.Events;

public abstract class TextureFinder : MonoBehaviour
{
    [SerializeField] protected Texture2D texture;
    public MaterialChanger mc;
    protected string prevPath;

    public void Start()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(OnClick);
    }

    private void FindAndApply(string path)
    {
        byte[] data;
        if (System.IO.File.Exists(path))
        {
	    prevPath = path;
            texture.requestedMipmapLevel = 0;
            texture.filterMode = FilterMode.Point;
            data = System.IO.File.ReadAllBytes(path);
            texture.LoadImage(data);
        }
        ApplyTexture();
    }

    public void Reapply()
    {
	if(prevPath != null)
	    FindAndApply(prevPath);
    }

    protected abstract void ApplyTexture();

    private void OnCancel()
    {

    }

    public void OnClick()
    {
        FileBrowser.SetFilters(false, new string[] { ".png", ".jpg", ".jpeg" });
        FileBrowser.ShowLoadDialog((x) => FindAndApply(x[0]), OnCancel, FileBrowser.PickMode.Files);
    }
}
