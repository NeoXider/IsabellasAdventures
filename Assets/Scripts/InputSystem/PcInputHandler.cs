﻿using UnityEngine;

public class PcInputHandler : InputHandler
{
    public override Vector2 Directon => GetDirection();

    private InputSettings _inputSettings;

    public PcInputHandler()
    {
        _inputSettings = new InputSettings();
        _inputSettings.Enable();

        _inputSettings.Gameplay.Jump.performed += invokeEvent => JumpButtonEvent();
        _inputSettings.Gameplay.Fire.performed += invokeEvent => FireButtonEvent();
    }

    //get data
    private Vector2 GetDirection() => _inputSettings.Gameplay.Movement.ReadValue<Vector2>();
    private void JumpButtonEvent() => InvokeJumpButtonAction();
    private void FireButtonEvent() => InvokeFireButtonAction();
}