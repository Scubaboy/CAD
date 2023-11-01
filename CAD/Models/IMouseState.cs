using Evergine.Common.Input.Mouse;
using Evergine.Mathematics;

namespace CAD.Models
{
    public interface IMouseState
    {
        bool ButtonPressed { get; set; }
        bool ButtonReleased { get; set; }
        MouseButtons ActiveButton { get; set; }
        Vector2 ScreenPosition { get; set; }
    }
}
