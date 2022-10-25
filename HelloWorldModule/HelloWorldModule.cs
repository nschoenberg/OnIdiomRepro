using HelloWorldModule.Views;

namespace HelloWorldModule
{
    public class HelloWorldModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HelloPrismPage, HelloWorldModule>("Hello");
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }
    }
}