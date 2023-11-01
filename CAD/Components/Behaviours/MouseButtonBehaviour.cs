using CAD.Services;
using Evergine.Common.Input.Mouse;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using Evergine.Framework.Services;
using System;

namespace CAD.Components.Behaviours
{
    public class MouseButtonBehaviour : Behavior
    {
        [BindService]
        private MouseButtonService _mouseButtonService = null;

        [BindComponent(source: BindComponentSource.Scene, isRequired: true)]
        private Camera3D _camera = null;

        private MouseDispatcher _mouseDispatcher;

        protected override void OnActivated()
        {
            _mouseDispatcher = this._camera.Display?.MouseDispatcher;

            //register mouse events
            _mouseDispatcher.MouseButtonDown += _mouseButtonService.MouseButtonDown;
        }

        protected override void Update(TimeSpan gameTime)
        {
            if (_mouseDispatcher != null)
            {
                switch (_mouseDispatcher.) { }
            }
        }
    }
}
