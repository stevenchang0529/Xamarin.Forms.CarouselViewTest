using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
namespace Xamarin.Forms.CarouselViewTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyCarouselPage : CarouselPage
	{
		public MyCarouselPage ()
		{

            InitializeComponent();
		}
	}
}