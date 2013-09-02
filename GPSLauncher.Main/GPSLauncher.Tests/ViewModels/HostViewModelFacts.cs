using GPSLauncher.ViewModels;
using GPSLauncher.Facts.INotifyPropertyChangedExtensions;
using Xunit;

namespace GPSLauncher.Facts.ViewModels
{
    public class HostViewModelFacts
    {
        public class TheConstructor
        {
            HostViewModel vm = null;
            public TheConstructor()
            {
                vm = new HostViewModel();
            }
            [Fact]
            public void InitsSearchTextToSearch()
            {
                //assert
                Assert.Equal("Search", vm.SearchText);
            }

            [Fact]
            public void InitsTheStartScreenPropertyToTypeStartScreenViewModel()
            {
                Assert.NotNull(vm.StartScreen);
                Assert.IsType<StartScreenViewModel>(vm.StartScreen);
            }

            [Fact]
            public void InitsTheExitApplicationCommand()
            {
                Assert.NotNull(vm.ExitApplicationCommand);
            }

            [Fact]
            public void InitsTheSearchGotFocusCommand()
            {
                Assert.NotNull(vm.SearchGotFocusCommand);
            }

            [Fact]
            public void InitsTheSearchLostFocusCommand()
            {
                Assert.NotNull(vm.SearchLostFocusCommand);
            }

            [Fact]
            public void InitsTheExecuteSearchCommand()
            {
                Assert.NotNull(vm.ExecuteSearchCommand);
            }
        }
        public class TheSearchTextProperty
        {
            [Fact]
            public void SetterSetsAndGetterGets()
            {
                //arrange
                var vm = new HostViewModel {SearchText = "Setter Works"};

                //act/assert
                Assert.Equal("Setter Works", vm.SearchText);
            }

            [Fact]
            public void ChangesTriggerPropertyChanged()
            {
                //arrange
                var vm = new HostViewModel();

                //act/assert
                vm.ShouldNotifyOn(s => s.SearchText).When(s => s.SearchText = "Some new Value");
            }
        }
        public class TheSearchGotFocusMethod
        {
            [Fact]
            public void SetsSearchTextToEmptyString()
            {
                //arrange
                var vm = new HostViewModel { SearchText = "Some Value" };

                //act
                vm.SearchGotFocus(null);

                //assert
                Assert.Equal(string.Empty, vm.SearchText);
            }
        }

        public class TheSearchLostFocusMethod
        {
            [Fact]
            public void SetsSearchTextToSearchWhenSearchTextIsEmpty()
            {
                //arrange
                var vm = new HostViewModel { SearchText = string.Empty };

                //act
                vm.SearchLostFocus(null);

                //assert
                Assert.Equal("Search", vm.SearchText);
            }
            [Fact]
            public void DoesntModifySearchTextIfSearchTextIsntEmpty()
            {
                //arrange
                var vm = new HostViewModel { SearchText = "Some String" };

                //act
                vm.SearchLostFocus(null);

                //assert
                Assert.Equal("Some String", vm.SearchText);
            }
        }

    }
}

