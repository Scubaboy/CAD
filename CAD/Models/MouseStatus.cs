using Evergine.Common.Input.Mouse;

namespace CAD.Models
{
    public class MouseStatus : IMouseStatus
    {
        private bool _buttonPressed;
        private bool _buttonReleased;

        public bool ButtonPressed 
        { 
            get
            {
                return _buttonPressed;
            }
            set
            {
                _buttonPressed = value;
                _buttonReleased = true;
            }
        }
        public bool ButtonReleased 
        { 
            get
            {
                return _buttonReleased;
            }
            set
            {
                _buttonReleased= value;
                _buttonPressed= false;
            }
        }
        
        public MouseButtons ActiveButton { get; set; }
        
        public MouseStatus() 
        {
            ButtonPressed = false;
            ButtonReleased = true;
            ActiveButton = MouseButtons.None;
        }
    }
}
