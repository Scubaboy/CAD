using Evergine.Common.Input.Mouse;
using Evergine.Framework;
using Evergine.Framework.Services;

namespace CAD.Services
{
    public  class MouseButtonService : Service, IMouseButtonService
    {
        [BindService]
        private DesignModeService _designModeService = null;

        public void MouseButtonDown (object sender, MouseButtonEventArgs e)
        {
            switch (_designModeService.Mode)
            {
                case Types.DesignMode.None:
                    {
                        if (e.Button == MouseButtons.Left)
                        {

                        }

                        break;
                    }
            }

        }
    }
}
