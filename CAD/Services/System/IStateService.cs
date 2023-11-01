using CAD.Models;

namespace CAD.Services.System
{
    public interface IStateService
    {
        IMouseState MouseState { get; }
    }
}
