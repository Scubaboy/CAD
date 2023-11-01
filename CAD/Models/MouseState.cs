using Evergine.Common.Input.Mouse;
using Evergine.Mathematics;

namespace CAD.Models
{
    public class MouseState : IMouseState
    {
        /// <summary>
        /// 
        /// </summary>
        private bool _buttonPressed;
        
        /// <summary>
        /// 
        /// </summary>
        private bool _buttonReleased;

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
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
        
        /// <summary>
        /// 
        /// </summary>
        public MouseButtons ActiveButton { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Vector2 ScreenPosition { get;set; }

        /// <summary>
        /// 
        /// </summary>
        public MouseState() 
        {
            ButtonPressed = false;
            ActiveButton = MouseButtons.None;
        }
    }
}
