using App1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Home
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VHHome : ContentPage
	{
		private VMDragonBall _viewModel;
		public VHHome ()
		{
			InitializeComponent ();
			_viewModel = new VMDragonBall();
			BindingContext = _viewModel;
		}
	}
}