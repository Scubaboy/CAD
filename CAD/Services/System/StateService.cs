using CAD.Models;
using Evergine.Framework.Services;

namespace CAD.Services.System
{
    public class StateService : Service, IStateService
    {
        public IMouseState MouseState {get;set;}

        public StateService()
        {
            MouseState = new MouseState();  
        }
    }
}
