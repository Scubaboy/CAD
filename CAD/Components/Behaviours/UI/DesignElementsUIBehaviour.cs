using Evergine.Bindings.Imgui;
using Evergine.Framework;
using Evergine.UI;
using System;

namespace CAD.Components.Behaviours.UI
{
    public unsafe  class DesignElementsUIBehaviour : Behavior
    {
        private bool imguiDemoOpen = true;
        protected override void Update(TimeSpan gameTime)
        {
            ImguiNative.igShowDemoWindow(this.imguiDemoOpen.Pointer());
        }
    }
}
