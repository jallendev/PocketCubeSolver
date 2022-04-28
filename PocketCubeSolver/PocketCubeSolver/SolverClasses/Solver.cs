using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketCubeSolver.SolverClasses
{
    class Solver
    {
		public const int GRAPH_STATE_DIAMETER = 14;

		//WORKS CITED
		/** The solution methodology is derived from an MIT lecture here: https://ocw.mit.edu/courses/6-006-introduction-to-algorithms-fall-2011/resources/lecture-13-breadth-first-search-bfs/ 
		 The lecture goes over breadth first search and discusses a methodology for solving a rubiks cube by building a graph, and running a shortest path algorithm to determine the solution.
		Other inspiration derived from an explanation of the Bellman-Ford algorithm in java here: https://www.geeksforgeeks.org/bellman-ford-algorithm-dp-23/*/
		public static string solve(CubeState state)
		{
			Dictionary<CubeState, string> forwardParents = new Dictionary<CubeState, string>();
			Dictionary<CubeState, string> backwardParents = new Dictionary<CubeState, string>();
			LinkedList<CubeState> fqueue = new LinkedList<CubeState>();
			LinkedList<CubeState> bqueue = new LinkedList<CubeState>();
			CubeState src = state, end = new CubeState();
			forwardParents[end] = null;
			backwardParents[src] = null;
			fqueue.AddLast(end);
			fqueue.AddLast(new CubeState(true));
			bqueue.AddLast(src);

			// check if cube already solved
			if (end.equals(src))
				return "Already solved";

			// bfs visit from both ends of graph
			int graphRadius = GRAPH_STATE_DIAMETER / 2;
			for (int i = 0; i <= graphRadius; i++)
			{
				while (true)
				{
					end = fqueue.First();
					fqueue.RemoveFirst();
					if (end.isNullState)
					{
						fqueue.AddLast(new CubeState(true));
						break;
					}

					foreach (KeyValuePair<string, CubeState> move in end.getReachableStates())
					{
						if (!forwardParents.ContainsKey(move.Value))
						{
							forwardParents[move.Value] = move.Key;
							fqueue.AddLast(move.Value);
						}
					}

					src = bqueue.First();
					bqueue.RemoveFirst();

					foreach (KeyValuePair<string, CubeState> move in src.getReachableStates())
					{
						if (!backwardParents.ContainsKey(move.Value))
						{
							backwardParents[move.Value] = move.Key;
							bqueue.AddLast(move.Value);
						}
						// same state discovered in both ends of search
						if (forwardParents.ContainsKey(move.Value))
						{
							string endpath = path(move.Value, forwardParents);
							string srcpath = path(move.Value, backwardParents);
							srcpath = reverse(srcpath);
							string solutionPath = srcpath + " " + endpath;
							return solutionPath;
						}
					}
				}
			}

			return "No solution, impossible configuration";

		}

		private static string reverse(string path)
		{
			path += " ";
			string reverse = "";

			for (int i = 0; i < path.Length; i++)
			{
				if (path[i] == ' ')
					reverse += "' ";
				else if (path[i] != '\'')
					reverse += path[i];
				else
				{
					reverse += " ";
					i++;
				}
			}

			string[] ar = reverse.Split(' ');
			for (int i = 0; i < ar.Length / 2; i++)
			{
				string temp = ar[i];
				ar[i] = ar[ar.Length - 1 - i];
				ar[ar.Length - 1 - i] = temp;
			}

			return string.Join(" ", ar);
		}

		private static string path(CubeState state, Dictionary<CubeState, string> parents)
		{
			string path = parents[state];
			CubeState next = new CubeState(state.positions);

			while (parents[next] != null)
			{
				path += " " + parents[next];
				next = new CubeState(state.positions);
			}

			return path;
		}

	}
}
