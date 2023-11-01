using Evergine.Common.Input.Mouse;

namespace CAD.Models
{
    public interface IMouseStatus
    {
        bool ButtonPressed { get; set; }
        bool ButtonReleased { get; set; }
        MouseButtons ActiveButton { get; set; }
    }
}
