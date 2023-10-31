using Evergine.Common.Input.Mouse;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using System;

namespace CAD.Components.Behaviours
{
    public class MouseObjectSelectionBehaviour : Behavior
    {
        [BindComponent(source: BindComponentSource.Scene, isRequired: true)]
        private Camera3D _camera = null;

        private MouseDispatcher _mouseDispatcher;

        protected override void OnActivated()
        {
            _mouseDispatcher = this._camera.Display?.MouseDispatcher;
        }

        protected override void Update(TimeSpan gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
