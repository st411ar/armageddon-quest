using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ArmageddonQuest
{
	internal enum Position
	{
		Ld,
		Lb,
		Sw,
		Cd,
		Rd,
		Rb,
		Dm,
		Lm,
		Cm,
		Rm,
		Lw,
		Am,
		Rw,
		Fr,
		Lf,
		Cf,
		Rf,
		St
	}

	internal enum Formation
	{
		F442,
		F352,
		F532,
		F433,
		F343,
		F451,
		F361,
		F424,
		F541
	}

	internal class FormationPositions
	{
		public readonly Formation Formation;
		public readonly List<Position>[] PositionsMatrix = new List<Position>[10];
		
		public FormationPositions(Formation formation)
		{
			// Console.WriteLine($"FormationPositions construction");
			this.Formation = formation;
			
			Console.WriteLine($"this.formation: {this.Formation}");
			
			// PrintMatrix();

			for (var i = 0; i < PositionsMatrix.Length; i++)
			{
				PositionsMatrix[i] = new List<Position>();
			}
			
			// PrintMatrix();

			GenerateMatrix();

			// PrintMatrix();
		}


		private void GenerateMatrix()
		{
			switch (Formation)
			{
				case Formation.F442:
					PositionsMatrix[0] = new List<Position> { Position.Ld, Position.Lb };
					PositionsMatrix[1] = new List<Position> { Position.Sw, Position.Cd };
					PositionsMatrix[2] = new List<Position> { Position.Cd };
					PositionsMatrix[3] = new List<Position> { Position.Rd, Position.Rb };
					PositionsMatrix[4] = new List<Position> { Position.Lm, Position.Lw };
					PositionsMatrix[5] = new List<Position> { Position.Dm, Position.Cm, Position.Fr };
					PositionsMatrix[6] = new List<Position> { Position.Cm, Position.Am, Position.Fr };
					PositionsMatrix[7] = new List<Position> { Position.Rm, Position.Rw };
					PositionsMatrix[8] = new List<Position> { Position.Lf, Position.Cf, Position.St };
					PositionsMatrix[9] = new List<Position> { Position.Rf, Position.Cf, Position.St};
					break;
				case Formation.F352:
					PositionsMatrix[0] = new List<Position> { Position.Ld, Position.Lb };
					PositionsMatrix[1] = new List<Position> { Position.Cd };
					PositionsMatrix[2] = new List<Position> { Position.Rd, Position.Rb };
					PositionsMatrix[3] = new List<Position> { Position.Lm, Position.Lw };
					PositionsMatrix[4] = new List<Position> { Position.Dm, Position.Cm, Position.Fr };
					PositionsMatrix[5] = new List<Position> { Position.Dm, Position.Cm, Position.Fr };
					PositionsMatrix[6] = new List<Position> { Position.Cm, Position.Am, Position.Fr };
					PositionsMatrix[7] = new List<Position> { Position.Rm, Position.Rw };
					PositionsMatrix[8] = new List<Position> { Position.Lf, Position.Cf, Position.St };
					PositionsMatrix[9] = new List<Position> { Position.Rf, Position.Cf, Position.St};
					break;
				case Formation.F532:
					PositionsMatrix[0] = new List<Position> { Position.Ld, Position.Lb };
					PositionsMatrix[1] = new List<Position> { Position.Sw, Position.Cd };
					PositionsMatrix[2] = new List<Position> { Position.Cd };
					PositionsMatrix[3] = new List<Position> { Position.Cd };
					PositionsMatrix[4] = new List<Position> { Position.Rd, Position.Rb };
					PositionsMatrix[5] = new List<Position> { Position.Lm, Position.Lw };
					PositionsMatrix[6] = new List<Position> { Position.Dm, Position.Cm, Position.Am, Position.Fr };
					PositionsMatrix[7] = new List<Position> { Position.Rm, Position.Rw };
					PositionsMatrix[8] = new List<Position> { Position.Lf, Position.Cf, Position.St };
					PositionsMatrix[9] = new List<Position> { Position.Rf, Position.Cf, Position.St};
					break;
				case Formation.F433:
					PositionsMatrix[0] = new List<Position> { Position.Ld, Position.Lb };
					PositionsMatrix[1] = new List<Position> { Position.Sw, Position.Cd };
					PositionsMatrix[2] = new List<Position> { Position.Cd };
					PositionsMatrix[3] = new List<Position> { Position.Rd, Position.Rb };
					PositionsMatrix[4] = new List<Position> { Position.Lm, Position.Lw };
					PositionsMatrix[5] = new List<Position> { Position.Dm, Position.Cm, Position.Am, Position.Fr };
					PositionsMatrix[6] = new List<Position> { Position.Rm, Position.Rw };
					PositionsMatrix[7] = new List<Position> { Position.Lf, Position.Cf, Position.St };
					PositionsMatrix[8] = new List<Position> { Position.Cf, Position.St };
					PositionsMatrix[9] = new List<Position> { Position.Rf, Position.Cf, Position.St};
					break;
				case Formation.F343:
					PositionsMatrix[0] = new List<Position> { Position.Ld, Position.Lb };
					PositionsMatrix[1] = new List<Position> { Position.Cd };
					PositionsMatrix[2] = new List<Position> { Position.Rd, Position.Rb };
					PositionsMatrix[3] = new List<Position> { Position.Lm, Position.Lw };
					PositionsMatrix[4] = new List<Position> { Position.Dm, Position.Cm, Position.Fr };
					PositionsMatrix[5] = new List<Position> { Position.Cm, Position.Am, Position.Fr };
					PositionsMatrix[6] = new List<Position> { Position.Rm, Position.Rw };
					PositionsMatrix[7] = new List<Position> { Position.Lf, Position.Cf, Position.St };
					PositionsMatrix[8] = new List<Position> { Position.Cf, Position.St };
					PositionsMatrix[9] = new List<Position> { Position.Rf, Position.Cf, Position.St};
					break;
				case Formation.F451:
					PositionsMatrix[0] = new List<Position> { Position.Ld, Position.Lb };
					PositionsMatrix[1] = new List<Position> { Position.Sw, Position.Cd };
					PositionsMatrix[2] = new List<Position> { Position.Cd };
					PositionsMatrix[3] = new List<Position> { Position.Rd, Position.Rb };
					PositionsMatrix[4] = new List<Position> { Position.Lm, Position.Lw };
					PositionsMatrix[5] = new List<Position> { Position.Dm, Position.Cm, Position.Fr };
					PositionsMatrix[6] = new List<Position> { Position.Dm, Position.Cm, Position.Fr };
					PositionsMatrix[7] = new List<Position> { Position.Cm, Position.Am, Position.Fr };
					PositionsMatrix[8] = new List<Position> { Position.Rm, Position.Rw };
					PositionsMatrix[9] = new List<Position> { Position.Cf, Position.St };
					break;
				case Formation.F361:
					PositionsMatrix[0] = new List<Position> { Position.Ld, Position.Lb };
					PositionsMatrix[1] = new List<Position> { Position.Cd };
					PositionsMatrix[2] = new List<Position> { Position.Rd, Position.Rb };
					PositionsMatrix[3] = new List<Position> { Position.Lm, Position.Lw };
					PositionsMatrix[4] = new List<Position> { Position.Dm };
					PositionsMatrix[5] = new List<Position> { Position.Dm, Position.Cm, Position.Fr };
					PositionsMatrix[6] = new List<Position> { Position.Cm, Position.Fr };
					PositionsMatrix[7] = new List<Position> { Position.Cm, Position.Am, Position.Fr };
					PositionsMatrix[8] = new List<Position> { Position.Rm, Position.Rw };
					PositionsMatrix[9] = new List<Position> { Position.Cf, Position.St };
					break;
				case Formation.F424:
					PositionsMatrix[0] = new List<Position> { Position.Ld, Position.Lb };
					PositionsMatrix[1] = new List<Position> { Position.Sw, Position.Cd };
					PositionsMatrix[2] = new List<Position> { Position.Cd };
					PositionsMatrix[3] = new List<Position> { Position.Rd, Position.Rb };
					PositionsMatrix[4] = new List<Position> { Position.Lm, Position.Cm, Position.Fr };
					PositionsMatrix[5] = new List<Position> { Position.Rm, Position.Cm, Position.Fr };
					PositionsMatrix[6] = new List<Position> { Position.Lf };
					PositionsMatrix[7] = new List<Position> { Position.Cf, Position.St };
					PositionsMatrix[8] = new List<Position> { Position.Cf, Position.St };
					PositionsMatrix[9] = new List<Position> { Position.Rf };
					break;
				case Formation.F541:
					PositionsMatrix[0] = new List<Position> { Position.Ld, Position.Lb };
					PositionsMatrix[1] = new List<Position> { Position.Sw, Position.Cd };
					PositionsMatrix[2] = new List<Position> { Position.Cd };
					PositionsMatrix[3] = new List<Position> { Position.Cd };
					PositionsMatrix[4] = new List<Position> { Position.Rd, Position.Rb };
					PositionsMatrix[5] = new List<Position> { Position.Lm, Position.Lw };
					PositionsMatrix[6] = new List<Position> { Position.Dm, Position.Cm, Position.Fr };
					PositionsMatrix[7] = new List<Position> { Position.Cm, Position.Am, Position.Fr };
					PositionsMatrix[8] = new List<Position> { Position.Rm, Position.Rw };
					PositionsMatrix[9] = new List<Position> { Position.Cf, Position.St };
					break;
			}
		}

		private void PrintMatrix()
		{
			Console.WriteLine($"PositionsMatrix.Length: {PositionsMatrix.Length}");

			foreach (var positions in PositionsMatrix)
			{
				Console.WriteLine($"positions: {positions}");
				if (positions != null)
				{
					foreach (var position in positions)
					{
						Console.Write($"\t{position}");
					}
				}
				Console.WriteLine();
			}
		}
	}
	
	internal class FormationVariation
	{
		public Formation Formation;
		public readonly Position[] Positions;

		public FormationVariation(Formation formation, Position[] positions)
		{
			Formation = formation;
			Positions = positions;
		}
	}

	internal class FormationVariationsBuilder
	{
		private readonly FormationPositions formationPositions;

		public FormationVariationsBuilder(FormationPositions formationPositions)
		{
			this.formationPositions = formationPositions;
		}

		public List<FormationVariation> BuildAllFormationVariations()
		{
			var variations = new List<FormationVariation>();

			var variation = BuildInitialVariation();
			if (IsValid(variation) && !IsRepeated(variations, variation))
				variations.Add(variation);

			while (!IsLastVariation(variation))
			{
				variation = BuildNextVariation(variation);
				if (IsValid(variation) && !IsRepeated(variations, variation))
					variations.Add(variation);
			}

			return variations;
		}

		private FormationVariation BuildInitialVariation()
		{
			var matrix = formationPositions.PositionsMatrix;
			var positions = new Position[matrix.Length];
			for (var i = 0; i < matrix.Length; i++)
			{
				positions[i] = matrix[i].First();
			}

			return new FormationVariation(formationPositions.Formation, positions);
		}

		private FormationVariation BuildNextVariation(FormationVariation variation)
		{
			var positions = variation.Positions;
			var nextPositions = new Position[10];
			for (var i = 0; i < positions.Length; i++)
			{
				nextPositions[i] = positions[i];
			}
			
			for (var i = 9; i >= 0; i--)
			{
				var position = positions[i];
				var availablePositions = formationPositions.PositionsMatrix[i];
				
				var index = availablePositions.FindIndex(p => p == position);

				if (index != availablePositions.Count - 1)
				{
					nextPositions[i] = availablePositions[index + 1];
					break;
				}
				
				nextPositions[i] = availablePositions.First();
			}

			return new FormationVariation(formationPositions.Formation, nextPositions);
		}

		private bool IsLastVariation(FormationVariation variation)
		{
			var positions = variation.Positions;
			var matrix = formationPositions.PositionsMatrix;
			return !matrix.Where((t, i) => positions[i] != t.Last()).Any();
		}

		private bool IsValid(FormationVariation variation)
		{
			var positions = variation.Positions;

			return ValidateAmWithWingers(positions)
			       && ValidateFrCount(positions)
			       && ValidateStCount(positions)
			       && ValidateForwards(positions)
			       && ValidateF424Midfield(variation);
		}

		private static bool ValidateAmWithWingers(Position[] positions)
		{
			var hasAm = positions.Any(p => p == Position.Am);
			if (!hasAm) return true;
			return !positions.Any(p => p == Position.Lw || p == Position.Rw);
		}

		private static bool ValidateFrCount(IEnumerable<Position> positions)
		{
			return positions.Count(position => position == Position.Fr) < 2;
		}

		private static bool ValidateStCount(IEnumerable<Position> positions)
		{
			return positions.Count(position => position == Position.St) < 2;
		}

		private static bool ValidateForwards(Position[] positions)
		{
			var hasWingerForward = positions.Any(position => position == Position.Lf || position == Position.Rf);
			if (!hasWingerForward) return true;
			return ValidateWingerForwardsSymmetry(positions) && ValidateCenterForwardsCountWhenWithWingerForwards(positions);
		}

		private static bool ValidateWingerForwardsSymmetry(Position[] positions)
		{
			var lfCount = positions.Count(p => p == Position.Lf);
			var rfCount = positions.Count(p => p == Position.Rf);

			return lfCount == 1 && rfCount == 1;
		}

		private static bool ValidateCenterForwardsCountWhenWithWingerForwards(Position[] positions)
		{
			if (positions.Count(IsForward) > 2) return true;
			return !positions.Any(position => position == Position.Cf || position == Position.St);
		}

		private static bool ValidateF424Midfield(FormationVariation variation)
		{
			if (variation.Formation != Formation.F424) return true;
			
			var positions = variation.Positions;
			var hasWingers = positions.Any(p => p == Position.Lm || p == Position.Rm);
			return !hasWingers || ValidateWingerMidfielders(positions);
		}

		private static bool ValidateWingerMidfielders(Position[] positions)
		{
			var lmCount = positions.Count(p => p == Position.Lm);
			var rmCount = positions.Count(p => p == Position.Rm);

			return lmCount == 1 && rmCount == 1;
		}

		private static bool IsForward(Position position)
		{
			return (int) position > 13;
		}

		public static bool IsRepeated(IEnumerable<FormationVariation> variations, FormationVariation variation)
		{
			return variations.Any(validVariation => CompareVariations(variation, validVariation));
		}

		private static bool CompareVariations(FormationVariation v1, FormationVariation v2)
		{
			var count1 = CalcPositionsCount(v1.Positions);
			var count2 = CalcPositionsCount(v2.Positions);

			return !count1.Where((t, i) => t != count2[i]).Any();
		}

		private static int[] CalcPositionsCount(Position[] positions)
		{
			var positionsCount = new int[18];
			for (var i = 0; i < 18; i++)
			{
				positionsCount[i] = 0;
			}

			foreach (var position in positions)
			{
				positionsCount[(int) position]++;
			}

			return positionsCount;
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
	        Console.WriteLine("start");

	        var formations = GetAllFormation();
	        var unMergedVariations = new List<int>();
	        var mergedVariations = new List<FormationVariation>();
	        foreach (var formation in formations)
	        {
		        var availablePositions = new FormationPositions(formation);
		        var builder = new FormationVariationsBuilder(availablePositions);
		        var variations = builder.BuildAllFormationVariations();

		        
		        unMergedVariations.Add(variations.Count);
		        mergedVariations = Merge(mergedVariations, variations);

		        Console.WriteLine($"variations number: {variations.Count}");
		        Console.WriteLine($"merged variations number: {mergedVariations.Count}");
	        }
	        
	        var sum = 0;
	        Console.WriteLine($"unMergedVariations.Count: {unMergedVariations.Count}");
	        foreach (var unMergedVariation in unMergedVariations)
	        {
		        sum += unMergedVariation;
		        Console.Write($"\t{unMergedVariation}");
	        }
	        Console.WriteLine($"\nsum = {sum}");

	        Console.WriteLine($"merged variations number: {mergedVariations.Count}");

	        Console.WriteLine($"writing all formation positions variations to file 'result.txt' ... start");
	        WriteToFile(mergedVariations);
	        Console.WriteLine($"writing all formation positions variations to file 'result.txt' ... start");

	        
	        var positionsVariations = mergedVariations.Count;
	        Console.WriteLine($"positionsVariations: {positionsVariations}");

	        var goalKeepersPlacements = 2;
	        Console.WriteLine($"goalKeepersPlacements: {goalKeepersPlacements}");
	        var fieldPlayersPlacements = Combinatorics.Placements(18, 10);
	        Console.WriteLine($"fieldPlayersPlacements: {fieldPlayersPlacements}");

	        var playersPlacements = goalKeepersPlacements * fieldPlayersPlacements;
	        Console.WriteLine($"playersPlacements: {playersPlacements}");

	        var result = positionsVariations * playersPlacements;
	        Console.WriteLine($"result: {result}");
	        

	        Console.WriteLine("stop");
        }

        private static IEnumerable<Formation> GetAllFormation()
        {
	        return new List<Formation>
	        {
		        Formation.F442,
		        Formation.F352,
		        Formation.F532,
		        Formation.F433,
		        Formation.F343,
		        Formation.F451,
		        Formation.F361,
		        Formation.F424,
		        Formation.F541
	        };
        }

        private static List<FormationVariation> Merge(List<FormationVariation> v1, List<FormationVariation> v2)
        {
	        var merged = v1.ToList();

	        foreach (var variation in v2.Where(variation => !FormationVariationsBuilder.IsRepeated(merged, variation)))
	        {
		        merged.Add(variation);
	        }

	        return merged;
        }

        private static void WriteToFile(List<FormationVariation> variations)
        {
	        
	        var sb = new StringBuilder();
	        
	        foreach (var variation in variations)
	        {
		        foreach (var position in variation.Positions)
		        {
			        sb.Append($"\t{position}");
		        }

		        sb.AppendLine();
	        }

	        var result = sb.ToString();
		        
		        
	        const string writePath = "result.txt";
	        try
	        {
		        using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
		        {
			        sw.WriteLine(result);
		        }
		        Console.WriteLine("Writing has been completed successfully");
	        }
	        catch (Exception e)
	        {
		        Console.WriteLine(e.Message);
	        }		        
		        
        }

    }

    class Combinatorics
    {
	    public static long Factorial(int i)
	    {
		    if (i < 0) throw new NotFiniteNumberException("input parameter less then zero");
		    if (i == 0) return 1;
		    return i * Factorial(i-1);
	    }

	    public static long Permutations(int i)
	    {
		    return Factorial(i);
	    }

	    public static long Placements(int all, int i)
	    {
		    return Factorial(all) / Factorial(all - i);
	    }

	    public static long Combinations(int all, int i)
	    {
		    return Placements(all, i) / Permutations(i);
	    }
    }
}
