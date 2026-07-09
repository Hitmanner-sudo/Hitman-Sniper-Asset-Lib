using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000017")]
public class CFX_SpawnSystem : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x0")]
	private static CFX_SpawnSystem instance;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] objectsToPreload;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x20")]
	public int[] objectsToPreloadTimes;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x28")]
	public bool hideObjectsInHierarchy;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x29")]
	private bool allObjectsLoaded;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, List<GameObject>> instantiatedObjects;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, int> poolCursors;

	[Token(Token = "0x17000016")]
	public static bool AllObjectsLoaded
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0xA8C0C0", Offset = "0xA8C0C0", VA = "0xA8C0C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xA8B90C", Offset = "0xA8B90C", VA = "0xA8B90C")]
	public static GameObject GetNextObject(GameObject sourceObj, bool activateObject = true)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xA8BB6C", Offset = "0xA8BB6C", VA = "0xA8BB6C")]
	public static void PreloadObject(GameObject sourceObj, int poolSize = 1)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xA8BE5C", Offset = "0xA8BE5C", VA = "0xA8BE5C")]
	public static void UnloadObjects(GameObject sourceObj)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xA8BBD8", Offset = "0xA8BBD8", VA = "0xA8BBD8")]
	private void addObjectToPool(GameObject sourceObject, int number)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xA8BEB8", Offset = "0xA8BEB8", VA = "0xA8BEB8")]
	private void removeObjectsFromPool(GameObject sourceObject)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xA8C118", Offset = "0xA8C118", VA = "0xA8C118")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xA8C168", Offset = "0xA8C168", VA = "0xA8C168")]
	private void Start()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xA8C1F4", Offset = "0xA8C1F4", VA = "0xA8C1F4")]
	public CFX_SpawnSystem()
	{
	}
}
