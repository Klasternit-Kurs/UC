using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UC
{
	/// <summary>
	/// Interaction logic for JuzerKontrola.xaml
	/// </summary>
	public partial class JuzerKontrola : UserControl
	{
		public string Labela { get; set; } = "Nesto tamo :)";

		public JuzerKontrola()
		{
			InitializeComponent();
			DataContext = this;
		}
	}
}
