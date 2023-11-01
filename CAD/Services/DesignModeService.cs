using CAD.Types;
using Evergine.Framework.Services;
using System;

namespace CAD.Services
{
    public class DesignModeService : Service, IDesignModeService
    {
        private DesignMode _designMode;

        public DesignMode Mode => _designMode;
    }
}
