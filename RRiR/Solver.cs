using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.Integration;
using MathNet.Numerics.LinearAlgebra;

namespace RRiR
{
	internal class Solver
	{
		uint N;
		double h;

		public Solver()
		{
			N = 0;
			h = 0;
		}

		public (List<double>, List<double>) Compute(uint n) {
			N = n;
			h = 2.0 / (double)N;
			Vector<double> UVector = solve();

			List<double> xs = new List<double>();
			List<double> ys = new List<double>();

			for (uint i = 0; i <= N; i++) {
				double x = (h * i);
				xs.Add(x);
				ys.Add(u(x, ref UVector));
			}

			return (xs, ys);
		}

		private double e(int i, double x)
		{
			double x1 = h * (i - 1);
			double x2 = h * i;
			double x3 = h * (i + 1);

			if (x1 <= x && x <= x2) return (x - x1) / h;
			else if (x > x2 && x <= x3) return (x3 - x) / h;
			return 0;
		}

		private double de(int i, double x)
		{
			double x1 = h * (i - 1);
			double x2 = h * i;
			double x3 = h * (i + 1);

			if (x1 <= x && x <= x2) return 1 / h;
			else if (x > x2 && x <= x3) return -1 / h;
			return 0;
		}

		private double k(double x)
		{
			if (x < 0 || x > 2) return 0;
			if (x <= 1) return 1;
			return 2 * x;
		}

		private double B(int i, int j, double lowerBound, double upperBound)
		{
			if (lowerBound < 1 && upperBound > 1) return GaussLegendreRule.Integrate(x => de(i, x) * de(j, x) * k(x), lowerBound, 1, 5) + GaussLegendreRule.Integrate(x => de(i, x) * de(j, x) * k(x), 1, upperBound, 5) - e(i, 0) * e(j, 0);
			else return GaussLegendreRule.Integrate(x => de(i, x) * de(j, x) * k(x), lowerBound, upperBound, 5) - e(i, 0) * e(j, 0);
		}

		private double L(int i, double lowerBound, double upperBound)
		{
			return 100 * GaussLegendreRule.Integrate(x => e(i, x) * x, lowerBound, upperBound, 5) - 20 * e(i, 0);
		}

		private double u(double x, ref Vector<double> us)
		{
			double value = 0;
			for (int i = 0; i < N; i++)
			{
				value += us[i] * e(i, x);
			}
			return value;
		}

		private Vector<double> solve()
		{
			double[,] BTab = new double[N,N];
			for (int i = 0; i < N; i++) {
				for (int j = 0; j < N; j++)
				{
					if (Math.Abs(i - j) == 1) BTab[i, j] = B(i, j, Math.Max(0, 2 * Math.Min(i, j) / (double)N), Math.Min(2, 2 * Math.Max(i, j) / (double)N));
					else BTab[i, j] = B(i, j, Math.Max(0, 2 * (i - 1) / (double)N), Math.Min(2, 2 * (i + 1) / (double)N));
				}
			}

			double[] LTab = new double[N];
			for (int i = 0; i < N; i++)
				LTab[i] = L(i, Math.Max(0, 2 * (i -1) / (double)N), Math.Min(2, 2 * (i + 1) / (double)N));

			var BMatrix = Matrix<double>.Build.DenseOfArray(BTab);
			var LVector = Vector<double>.Build.Dense(LTab);

			return BMatrix.Solve(LVector);
		}

	}
}
