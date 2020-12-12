﻿using System;
using UnityEngine;

namespace DefaultNamespace
{
    public sealed class PCInputKey : IInputKeyPress
    {
        public event Action<bool> OnKeyPressed = delegate(bool b) {  };
        private KeyCode _keyCode;
        
        public PCInputKey(KeyCode keyCode)
        {
            _keyCode = keyCode;
        }
        
        public void GetKey()
        {
            if (Input.GetKeyDown(_keyCode))
            {
                OnKeyPressed.Invoke(true);
            }
        }
    }
}