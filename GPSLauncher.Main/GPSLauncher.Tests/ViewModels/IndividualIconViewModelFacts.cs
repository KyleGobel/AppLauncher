using GPSLauncher.ViewModels;
using GPSLauncher.Facts.INotifyPropertyChangedExtensions;
using Xunit;

namespace GPSLauncher.Facts.ViewModels
{
    public class IndividualIconViewModelFacts
    {
        public class TheConstructor
        {
            [Fact]
            public void InitsTheLaunchCommand()
            {
                var vm = new IndividualIconViewModel();
                Assert.NotNull(vm.LaunchCommand);
            }
        }
        public class ImageSourceProperty
        {
            [Fact]
            public void SetterSetsAndGetterGets()
            {
                var vm = new IndividualIconViewModel { ImageSource = "A Test String" };

                Assert.Equal("A Test String", vm.ImageSource);
            }

            [Fact]
            public void ChangesTriggerPropertyChangedEvent()
            {
                var vm = new IndividualIconViewModel();

                vm.ShouldNotifyOn(x => x.ImageSource).When(x => x.ImageSource = "New Value");
            }
        }
        public class CaptionProperty
        {
            [Fact]
            public void SetterSetsAndGetterGets()
            {
                var vm = new IndividualIconViewModel { Caption = "A Test String" };

                Assert.Equal("A Test String", vm.Caption);
            }

            [Fact]
            public void ChangesTriggerPropertyChangedEvent()
            {
                var vm = new IndividualIconViewModel();

                vm.ShouldNotifyOn(x => x.Caption).When(x => x.Caption = "New Value");
            }
        }
        public class CommandProperty
        {
            [Fact]
            public void SetterSetsAndGetterGets()
            {
                var vm = new IndividualIconViewModel { Command = "A Test String" };

                Assert.Equal("A Test String", vm.Command);
            }

            [Fact]
            public void ChangesTriggerPropertyChangedEvent()
            {
                var vm = new IndividualIconViewModel();

                vm.ShouldNotifyOn(x => x.Command).When(x => x.Command = "New Value");
            }
        }
    }
}