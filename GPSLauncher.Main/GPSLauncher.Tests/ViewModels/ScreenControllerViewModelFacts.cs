using GPSLauncher.Facts.INotifyPropertyChangedExtensions;
using GPSLauncher.ViewModels;
using Xunit;

namespace GPSLauncher.Facts.ViewModels
{
    public class ScreenControllerViewModelFacts
    {
        public class TheConstructor
        {
            [Fact]
            public void InitsTheCurrentScreenToStartScreen()
            {
                var vm = new ScreenControllerViewModel();

                Assert.IsType<StartScreenViewModel>(vm.CurrentScreen);
            }
        }
        public class TheCurrentScreenProperty
        {
            [Fact]
            public void SetterSetsAndGetterGets()
            {
                var vm = new ScreenControllerViewModel { CurrentScreen = "A Test String" };

                Assert.Equal("A Test String", vm.CurrentScreen);
            }

            [Fact]
            public void ChangesTriggerPropertyChangedEvent()
            {
                var vm = new ScreenControllerViewModel();

                vm.ShouldNotifyOn(x => x.CurrentScreen).When(x => x.CurrentScreen = "New Value");
            }
        }
       
    }
}