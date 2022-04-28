using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketCubeSolver.SolverClasses
{
	//WORKS CITED
	/** The solution methodology is derived from an MIT lecture here: https://ocw.mit.edu/courses/6-006-introduction-to-algorithms-fall-2011/resources/lecture-13-breadth-first-search-bfs/ 
	 The lecture goes over breadth first search and discusses a methodology for solving a rubiks cube by building a graph, and running a shortest path algorithm to determine the solution.
	Other inspiration derived from an explanation of the Bellman-Ford algorithm in java here: https://www.geeksforgeeks.org/bellman-ford-algorithm-dp-23/*/
	class CubeState
    {
		/**
		* The cube permutation is stored in an array of chars denoting colors in each position
		* w - white
		* y - yellow
		* g - green
		* b - blue
		* o - orange
		* r - red
		* each consecutive 4 indices are a face labeled starting from
		* top left going around clockwise
		* i:0-3 top face (denoted by U)
		* i:4-7 left face (denoted by L)
		* i:8-11 front face (denoted by F)
		* i:12-15 right face (denoted by R)
		* i:16-19 bottom face (denoted by D)
		* i:20-23 back face (denoted by B)
		*   __B__
		* L/    /|
		* /__U_/ |
		* |    |R/
		* |__F_|/ 
		*    D     */
		public char[] positions;
		public bool isNullState;

		//default constructor creates a solved cube
		public CubeState()
		{
			// create a solved cube
			positions = new char[24];
			for (int i = 0; i < 4; i++)
				positions[i] = 'w';
			for (int i = 4; i < 8; i++)
				positions[i] = 'o';
			for (int i = 8; i < 12; i++)
				positions[i] = 'g';
			for (int i = 12; i < 16; i++)
				positions[i] = 'r';
			for (int i = 16; i < 20; i++)
				positions[i] = 'y';
			for (int i = 20; i < 24; i++)
				positions[i] = 'b';
			this.isNullState = false;
		}

		//constructs a cube with the given permutation
		public CubeState(char[] positions)
		{
			this.positions = positions;
			this.isNullState = false;
		}

		//Null constructor
		public CubeState(bool nullState)
		{
			this.isNullState = nullState;
		}

		/**
		 * The letters below denote various face moves and their inverses (clockwise/anticlockwise)
		 * F - front rotated clockwise
		 * F' - front counter clockwise
		 * R - right clockwise
		 * R' - right counter clockwise
		 * U - up clockwise
		 * U' - up counter clockwise
		 */
		private static int[] F = { 0, 1, 5, 6, 4, 16, 17, 7, 11, 8, 9, 10, 3, 13, 14, 2, 15, 12, 18, 19, 20, 21, 22, 23 };
		private static int[] Fi = moveInverse(F);
		private static int[] U = { 3, 0, 1, 2, 8, 9, 6, 7, 12, 13, 10, 11, 20, 21, 14, 15, 16, 17, 18, 19, 4, 5, 22, 23 };
		private static int[] Ui = moveInverse(U);
		private static int[] R = { 0, 9, 10, 3, 4, 5, 6, 7, 8, 17, 18, 11, 15, 12, 13, 14, 16, 23, 20, 19, 2, 21, 22, 1 };
		private static int[] Ri = moveInverse(R);

		//As the name suggests, changes clockwise moves to anticlockwise and vice versa
		public static int[] moveInverse(int[] p)
		{
			int n = p.Length;
			int[] g = new int[n];
			for (int i = 1; i < n; i++)
			{
				g[p[i]] = i;
			}
			return g;
		}

		//Applies a move to the given cube state and returns the state after the move
		public char[] moveApply(int[] move)
		{
			char[] newPositions = new char[24];
			for (int i = 0; i < 24; i++)
			{
				newPositions[i] = positions[move[i]];
			}
			return newPositions;
		}

		public Dictionary<string, CubeState> getReachableStates()
		{
			Dictionary<string, CubeState> moves = new Dictionary<string, CubeState>();
			addBasicMove("F'", F, moves);
			addBasicMove("F", Fi, moves);
			addBasicMove("U'", U, moves);
			addBasicMove("U", Ui, moves);
			addBasicMove("R'", R, moves);
			addBasicMove("R", Ri, moves);
			return moves;
		}

		private void addBasicMove(string name, int[] move, Dictionary<string, CubeState> moves)
		{
			CubeState state = new CubeState(moveApply(move));
			moves[name] = state;
		}

		public bool equals(Object obj)
		{
			CubeState state = (CubeState)obj;
			if (state.positions.Length != this.positions.Length) return false;
			for (int i = 0; i < this.positions.Length; i++)
			{
				if (this.positions[i] != state.positions[i])
					return false;
			}
			return true;
		}
	}
}
