using CAD.Models;

namespace CAD.Services.System
{
    public interface IStatusService
    {
        IMouseStatus MouseStatus { get; }
    }
}
