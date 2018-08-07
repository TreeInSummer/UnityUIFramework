﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISample : UIBase {

    public override void Awake()
    {
        base.Awake();
        this.CareCategory = EasyTouchEventCategoty.ETEC_SimpleTap + EasyTouchEventCategoty.ETEC_Drag;
    }

    public override void OnSimpleTap(Gesture gesture)
    {
        Debug.LogError("OK, OnSimpleTap");
    }

    public void OnBtnClick(GameObject button, bool isPress)
    {
        UIBase.ShowUI("UISample2");
    }


    public override void OnShow()
    {
        base.OnShow();
        RegisterEasyTouch(CareCategory);
    }
    public override void OnHide()
    {
        base.OnHide();
        UnregisterEasyTouch();
    }
}
