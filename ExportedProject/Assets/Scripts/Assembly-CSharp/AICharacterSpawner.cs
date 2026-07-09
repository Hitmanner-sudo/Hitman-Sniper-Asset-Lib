using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C0")]
public class AICharacterSpawner : Spawner
{
	[Serializable]
	[Token(Token = "0x20001C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592984", Offset = "0x592984")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LazyGameObject, bool> _003C_003E9__19_0;

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x9103FC", Offset = "0x9103FC", VA = "0x9103FC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x910404", Offset = "0x910404", VA = "0x910404")]
		internal bool _003CInstantiateCharacter_003Eb__19_0(LazyGameObject o)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000984")]
	[FieldOffset(Offset = "0xA0")]
	public LazyDamageSetup DamageRef;

	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0xA8")]
	public LazyGameObject[] ObjectsToAddRefs;

	[Token(Token = "0x4000986")]
	[FieldOffset(Offset = "0xB0")]
	public Material[] m_RandomMaterials;

	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0xB8")]
	public LazyInventoryItem[] SpawnInventory;

	[Token(Token = "0x4000988")]
	[FieldOffset(Offset = "0xC0")]
	public AlertLevel InitialThreatLevel;

	[Token(Token = "0x4000989")]
	[FieldOffset(Offset = "0xC8")]
	public LazyRogueData RogueDataRef;

	[Token(Token = "0x400098A")]
	[FieldOffset(Offset = "0xD0")]
	public LazyDropList DropListToAddRef;

	[Token(Token = "0x400098B")]
	[FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B22C8", Offset = "0x5B22C8")]
	private DropList _003CDropListToAdd_003Ek__BackingField;

	[Token(Token = "0x400098C")]
	[FieldOffset(Offset = "0xE0")]
	public bool StartOnSpawnState;

	[Token(Token = "0x400098D")]
	[FieldOffset(Offset = "0xE4")]
	public float RandomRadiusRange;

	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0x0")]
	private static int _id;

	[Token(Token = "0x400098F")]
	[FieldOffset(Offset = "0x4")]
	private static int _spawnerCount;

	[Token(Token = "0x170001E2")]
	public DropList DropListToAdd
	{
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0xA92180", Offset = "0xA92180", VA = "0xA92180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6140F4", Offset = "0x6140F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0xA92188", Offset = "0xA92188", VA = "0xA92188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614104", Offset = "0x614104")]
		set
		{
		}
	}

	[Token(Token = "0x6000B95")]
	[Address(RVA = "0xA92190", Offset = "0xA92190", VA = "0xA92190", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000B96")]
	[Address(RVA = "0xA92298", Offset = "0xA92298", VA = "0xA92298", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000B97")]
	[Address(RVA = "0xA923D0", Offset = "0xA923D0", VA = "0xA923D0", Slot = "17")]
	protected override Vector3 CalculateGroundPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000B98")]
	[Address(RVA = "0xA92440", Offset = "0xA92440", VA = "0xA92440", Slot = "16")]
	protected override Vector3 GetOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000B99")]
	[Address(RVA = "0xA924B0", Offset = "0xA924B0", VA = "0xA924B0", Slot = "14")]
	protected override Character InstantiateCharacter(Character characterPrefab)
	{
		return null;
	}

	[Token(Token = "0x6000B9A")]
	[Address(RVA = "0xA93150", Offset = "0xA93150", VA = "0xA93150", Slot = "15")]
	protected override Controller InstantiateController()
	{
		return null;
	}

	[Token(Token = "0x6000B9B")]
	[Address(RVA = "0xA92F80", Offset = "0xA92F80", VA = "0xA92F80")]
	private void RandomMaterial(GameObject root, Material[] aMaterials)
	{
	}

	[Token(Token = "0x6000B9C")]
	[Address(RVA = "0xA9324C", Offset = "0xA9324C", VA = "0xA9324C")]
	public AICharacterSpawner()
	{
	}

	[Token(Token = "0x6000B9E")]
	[Address(RVA = "0xA932AC", Offset = "0xA932AC", VA = "0xA932AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614114", Offset = "0x614114")]
	private bool _003CInstantiateCharacter_003Eb__19_1(RogueData x)
	{
		return default(bool);
	}
}
