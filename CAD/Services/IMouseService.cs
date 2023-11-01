using Evergine.Common.Input.Mouse;

namespace CAD.Services
{
    public interface IMouseService
    {
        void MouseButtonDown(object sender, MouseButtonEventArgs e);

        void MouseButtonUp(object sender, MouseButtonEventArgs e);

        void MouseMove(object sender, MouseEventArgs e);

        void MouseScroll(object sender, MouseScrollEventArgs e);

    }
}
