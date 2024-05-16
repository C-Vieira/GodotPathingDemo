class_name AStarPathVisualizer
extends Node

@export var tile_map : TileMap
@export var astar_pathfinder : AStarPathFinder

func _input(event):
	if astar_pathfinder.is_moving:
		draw_path(astar_pathfinder.current_id_path)

func draw_path(id_path):
	for i in id_path:
			tile_map.set_cell(0, i, 0, Vector2i(2, 1))
