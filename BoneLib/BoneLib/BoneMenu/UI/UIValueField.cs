﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BoneLib.BoneMenu.UI
{
    [MelonLoader.RegisterTypeInIl2Cpp]
    public class UIValueField : UIElement
    {
        public UIValueField(IntPtr ptr) : base(ptr) { }

        private Button _leftButton;
        private Button _rightButton;

        private void Awake()
        {
            _leftButton = transform.Find("button_stUP").GetComponent<Button>();
            _rightButton = transform.Find("button_stDown").GetComponent<Button>();

            SetupListeners();
        }

        private void SetupListeners()
        {
            Action onLeftPressed = () => _element?.OnSelectLeft();
            Action onRightPressed = () => _element?.OnSelectRight();

            if(_leftButton != null)
            {
                _leftButton.onClick.AddListener(onLeftPressed);
            }

            if (_rightButton != null)
            {
                _rightButton.onClick.AddListener(onRightPressed);
            }
        }
    }
}
