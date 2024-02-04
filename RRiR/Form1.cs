using System;
using System.Windows.Forms;

namespace RRiR
{
	public partial class Form1 : Form
	{
		Solver solver;

		private double k(double x)
		{
			if (x < 0 || x > 2) return 0;
			if (x <= 1) return 1;
			return 2 * x;
		}

		public Form1()
		{
			solver = new Solver();
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			plot.Plot.Title("u(x) function plot");
			plot.Refresh();
		}

		private void cumputeBtn_Click(object sender, EventArgs e)
		{
			uint N = 0;
			bool canConvert = uint.TryParse(nTBox.Text, out N);
			if (!canConvert || N < 3)
			{
				MessageBox.Show("N must be inteager value greater than 2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var values = solver.Compute(N);
			plot.Plot.AddScatter(values.Item1.ToArray(), values.Item2.ToArray(), label: String.Format("N = {0}", nTBox.Text));
			plot.Plot.AxisAuto(verticalMargin:0.05);
			plot.Plot.Legend();
			plot.Refresh();
		}

		private void clearPlotBtn_Click(object sender, EventArgs e)
		{
			plot.Plot.Clear();
			plot.Refresh();
		}
	}
}
