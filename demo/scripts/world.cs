using Godot;
using System;
using System.Text;

public partial class world : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Hello World");
		TileMap tmp = (TileMap)this.GetChild(0);
		Create(30, 30, tmp);
	}

	private static int[,] tiles;
	private static bool[,] vis;
	public static void Create(int n, int m, TileMap map)
	{
		tiles = new int[n,m];
		vis = new bool[n, m];
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < m; j++)
			{
				if (map.GetCellTileData(0, new Vector2I(j, i), false) == null)
					continue;
				//theres smth here
				var data = map.GetCellTileData(0, new Vector2I(j, i), false);
			//	data.
				tiles[i, j] = 1;
			}
		}
		Disp(tiles);
	}

	public static void Disp(int[,] thing)
	{
		for (int i = 0; i < thing.GetUpperBound(1); i++)
		{
			StringBuilder sb = new StringBuilder();
			for (int j = 0; j < thing.GetUpperBound(0); j++)
			{
				sb.Append(thing[i, j]);
			}
			GD.Print(sb.ToString());
		}
	}

	public static void Bfs()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
