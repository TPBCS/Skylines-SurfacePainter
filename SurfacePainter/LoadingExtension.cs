using ICities;

namespace SurfacePainter
{
    public class LoadingExtension : LoadingExtensionBase
    {

        public override void OnCreated(ILoading loading)
        {
            base.OnCreated(loading);
            SurfaceManager.instance.Setup();
        }

        public override void OnLevelLoaded(LoadMode mode)
        {
            base.OnLevelLoaded(mode);
            if (mode != LoadMode.LoadGame && mode != LoadMode.NewGame && mode != LoadMode.NewGameFromScenario && mode != LoadMode.NewTheme && mode != LoadMode.LoadTheme)
            {
                EltPlugin.RevertDetours();
            }
            else
            {
                SurfaceManager.UpdateWholeMap();
            }
        }
    }
}