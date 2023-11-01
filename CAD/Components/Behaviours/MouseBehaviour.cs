using CAD.Services;
using Evergine.Common.Input.Mouse;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using System;

namespace CAD.Components.Behaviours
{
    public class MouseBehaviour : Behavior
    {
        [BindService]
        private  MouseService _mouseService = null;

        [BindComponent(source: BindComponentSource.Scene, isRequired: true)]
        private Camera3D _camera = null;

        private MouseDispatcher _mouseDispatcher;

        protected override void OnActivated()
        {
            _mouseDispatcher = this._camera.Display?.MouseDispatcher;

            if (_mouseDispatcher != null)
            {
                //register mouse events
                _mouseDispatcher.MouseButtonDown += _mouseService.MouseButtonDown;
                _mouseDispatcher.MouseMove += _mouseService.MouseMove;
                _mouseDispatcher.MouseButtonUp += _mouseService.MouseButtonUp;
                _mouseDispatcher.MouseScroll += _mouseService.MouseScroll;
            }

            base.OnActivated();
        }

        protected override void Update(TimeSpan gameTime)
        {
            
        }
    }
}
