﻿using UnityEditor;
using UnityEngine;


	public class Tools : Editor
	{
		[MenuItem("Tools/Reconnect TileConnect")]
		private static void RevertTileConnect()
		{
			//            var triggers = FindObjectsOfType<ConnectTrigger>();
			//
			//            foreach (var t in triggers)
			//            {
			//                PrefabUtility.RevertPrefabInstance(t.gameObject);
			//            }
		}

		[MenuItem("Tools/Set Ambient Tiles")]
		private static void SetAmbientTiles()
		{
			FloorTile[] tiles = FindObjectsOfType<FloorTile>();

			foreach (FloorTile t in tiles)
			{
				t.CheckAmbientTile();
			}
		}

		[MenuItem("Tools/Revert To Prefab %r")]
		private static void RevertPrefabs()
		{
			GameObject[] selection = Selection.gameObjects;

			if (selection.Length > 0)
			{
				for (int i = 0; i < selection.Length; i++)
				{
					PrefabUtility.RevertPrefabInstance(selection[i]);
					PrefabUtility.ReconnectToLastPrefab(selection[i]);
				}
			}
			else
			{
				Logger.Log("Cannot revert to prefab - nothing selected");
			}
		}

		// TODO replace for new tilemap system
		//		[MenuItem("Tools/Resection Tiles")]
		//		static void ConnectTiles2Sections()
		//		{
		//			var registerTiles = FindObjectsOfType<RegisterTile>();
		//
		//			foreach (var r in registerTiles) {
		//				var p = r.transform.position;
		//
		//				int x = Mathf.RoundToInt(p.x);
		//				int y = Mathf.RoundToInt(p.y);
		//
		//				r.transform.MoveToSection(Matrix.Matrix.At(x, y).Section);
		//				//PrefabUtility.RevertPrefabInstance(r.gameObject);
		//			}
		//		}
	}
