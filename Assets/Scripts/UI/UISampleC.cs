﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISampleC : UIBase
{

    public override void OnShow(object data)
    {
        Debug.LogError(DateTime.Now.ToString() + " UISampleC OnShow");
    }
    public override void UpdateUIByDefaultDataOnShow()
    {
        Debug.LogError(DateTime.Now.ToString() + " UISampleC UpdateUIByDefaultDataOnShow...");
    }
    public override IEnumerator LoadData(UIAsyncRequestResult res)
    {
        LockUI("UISampleC");
        Debug.LogError(DateTime.Now.ToString() + " UISampleC LoadData Start...");
        yield return new WaitForSeconds(2);
        Debug.LogError(DateTime.Now.ToString() + " UISampleC LoadData End...");
        UnLockUI("UISampleC");
    }
    public override void UpdateUIOnShow()
    {
        Debug.LogError(DateTime.Now.ToString() + " UISampleC UpdateUIOnShow...");
    }

    public void OnBtnClick(GameObject button, bool isPress)
    {
        UIBase.ShowUI("UISampleA");
    }
    public void OnBtnClose(GameObject button, bool isPress)
    {
        Close();
    }
}
