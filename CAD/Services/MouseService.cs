using CAD.Services.System;
using Evergine.Common.Input.Mouse;
using Evergine.Framework;
using Evergine.Framework.Services;

namespace CAD.Services
{
    public  class MouseService : Service, IMouseService
    {
        [BindService]
        private StateService _stateService = null;

        [BindService]
        private LoggerService _loggerService = null;

        public void MouseButtonDown (object sender, MouseButtonEventArgs e)
        {
            _loggerService.Log($"Mouse button {e.Button} pressed.");
            _stateService.MouseState.ButtonPressed = true;
            _stateService.MouseState.ActiveButton = e.Button;
            _stateService.MouseState.ScreenPosition = e.Position.ToVector2();

        }

        public void MouseButtonUp(object sender, MouseButtonEventArgs e)
        {
            _loggerService.Log($"Mouse button {e.Button} released.");
            _stateService.MouseState.ButtonReleased = true;
            _stateService.MouseState.ActiveButton = MouseButtons.None;
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            _loggerService.Log($"Mouse position {e.Position} screen space.");
            _stateService.MouseState.ScreenPosition = e.Position.ToVector2();
        }

        public void MouseScroll(object sender, MouseScrollEventArgs e)
        {
            _loggerService.Log($"Mouse scroll  Delta - {e.Delta} Direction - {e.Direction}");
        }
    }
}
