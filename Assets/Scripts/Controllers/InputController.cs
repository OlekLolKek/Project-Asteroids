﻿namespace DefaultNamespace
{
    public sealed class InputController : IExecutable
    {
        private readonly IInputChangeAxis _horizontal;
        private readonly IInputChangeAxis _vertical;
        private readonly IInputChangeAxis _mouseX;
        private readonly IInputChangeAxis _mouseY;
        private readonly IInputKeyHold _accelerate;


        public InputController((IInputChangeAxis horizontal, IInputChangeAxis vertical) keyboard,
            (IInputChangeAxis mouseX, IInputChangeAxis mouseY) InputMouse,
            IInputKeyHold inputAcceleration)
        {
            _horizontal = keyboard.horizontal;
            _vertical = keyboard.vertical;
            _mouseX = InputMouse.mouseX;
            _mouseY = InputMouse.mouseY;
            _accelerate = inputAcceleration;
        }

        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();
            _mouseX.GetAxis();
            _mouseY.GetAxis();
            _accelerate.GetKey();
        }
    }
}