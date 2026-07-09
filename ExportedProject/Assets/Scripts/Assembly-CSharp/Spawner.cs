using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20001C6")]
public class Spawner : GameMonoBehaviour
{
	[Token(Token = "0x20001C7")]
	public class SpawnerEventArgs : EventArgs
	{
		[Token(Token = "0x40009B1")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B2338", Offset = "0x5B2338")]
		private Spawner _003CSpawner_003Ek__BackingField;

		[Token(Token = "0x40009B2")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B2348", Offset = "0x5B2348")]
		private Character _003CCharacter_003Ek__BackingField;

		[Token(Token = "0x170001E4")]
		public Spawner Spawner
		{
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0xA52304", Offset = "0xA52304", VA = "0xA52304")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6141C4", Offset = "0x6141C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0xA5230C", Offset = "0xA5230C", VA = "0xA5230C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6141D4", Offset = "0x6141D4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		public Character Character
		{
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0xA52314", Offset = "0xA52314", VA = "0xA52314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6141E4", Offset = "0x6141E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0xA5231C", Offset = "0xA5231C", VA = "0xA5231C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6141F4", Offset = "0x6141F4")]
			set
			{
			}
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0xA52324", Offset = "0xA52324", VA = "0xA52324")]
		public SpawnerEventArgs()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592994", Offset = "0x592994")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40009B3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LazyCharacter, bool> _003C_003E9__21_0;

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0xA51C78", Offset = "0xA51C78", VA = "0xA51C78")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0xA51C80", Offset = "0xA51C80", VA = "0xA51C80")]
		internal bool _003CStart_003Eb__21_0(LazyCharacter x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20001C9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5929A4", Offset = "0x5929A4")]
	private sealed class _003CSpawnWithDelay_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009B5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x20")]
		public Spawner _003C_003E4__this;

		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0x28")]
		public float addDelay;

		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x2C")]
		public int spawnSpecificIndex;

		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x30")]
		private LazyCharacter _003ClazyCharacter_003E5__2;

		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0x38")]
		private LazyRuntimeAnimatorController _003Ccontroller_003E5__3;

		[Token(Token = "0x170001E6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0xA522B4", Offset = "0xA522B4", VA = "0xA522B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0xA522FC", Offset = "0xA522FC", VA = "0xA522FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0xA51D0C", Offset = "0xA51D0C", VA = "0xA51D0C")]
		[DebuggerHidden]
		public _003CSpawnWithDelay_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0xA51D38", Offset = "0xA51D38", VA = "0xA51D38", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0xA51D3C", Offset = "0xA51D3C", VA = "0xA51D3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0xA522BC", Offset = "0xA522BC", VA = "0xA522BC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40009A3")]
	protected const float RAY_DISTANCE = 5f;

	[Token(Token = "0x40009A4")]
	protected const float SPAWN_Y_OFFSET = 1.5f;

	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x48")]
	public LazyCharacter[] CharactersPrefabRefs;

	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x50")]
	public LazyController ControllerLazyPrefab;

	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x58")]
	public bool SnapToGround;

	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x59")]
	public bool SpawnOnStart;

	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x5C")]
	public float Delay;

	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x60")]
	private GameTimer _timer;

	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x68")]
	private GameTimer _PreLoadtimer;

	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x78")]
	protected Vector3 _spawnPos;

	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x84")]
	protected Quaternion _spawnRot;

	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x98")]
	private List<Character> _spawnedCharacterList;

	[Token(Token = "0x170001E3")]
	public List<Character> Spawned
	{
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0xA7339C", Offset = "0xA7339C", VA = "0xA7339C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000025")]
	public event EventHandler<SpawnerEventArgs> OnSpawn
	{
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0xA730E4", Offset = "0xA730E4", VA = "0xA730E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614124", Offset = "0x614124")]
		add
		{
		}
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0xA73184", Offset = "0xA73184", VA = "0xA73184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614134", Offset = "0x614134")]
		remove
		{
		}
	}

	[Token(Token = "0x14000026")]
	public static event EventHandler<SpawnerEventArgs> GlobalOnSpawn
	{
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0xA73224", Offset = "0xA73224", VA = "0xA73224")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614144", Offset = "0x614144")]
		add
		{
		}
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0xA732E0", Offset = "0xA732E0", VA = "0xA732E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614154", Offset = "0x614154")]
		remove
		{
		}
	}

	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0xA733A4", Offset = "0xA733A4", VA = "0xA733A4", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0xA73624", Offset = "0xA73624", VA = "0xA73624", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0xA724D4", Offset = "0xA724D4", VA = "0xA724D4")]
	public void Spawn(int spawnSpecificIndex = -1, float addDelay = 0f)
	{
	}

	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0xA73738", Offset = "0xA73738", VA = "0xA73738")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x614164", Offset = "0x614164")]
	private IEnumerator SpawnWithDelay(int spawnSpecificIndex = -1, float addDelay = 0f)
	{
		return null;
	}

	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0xA737C4", Offset = "0xA737C4", VA = "0xA737C4")]
	private void SpawnCharacter(Character characterPrefab)
	{
	}

	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0xA73AE4", Offset = "0xA73AE4", VA = "0xA73AE4", Slot = "14")]
	protected virtual Character InstantiateCharacter(Character characterPrefab)
	{
		return null;
	}

	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0xA73C18", Offset = "0xA73C18", VA = "0xA73C18", Slot = "15")]
	protected virtual Controller InstantiateController()
	{
		return null;
	}

	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0xA739E0", Offset = "0xA739E0", VA = "0xA739E0")]
	private void AlignControllerToCharacter(Character character, Controller controller)
	{
	}

	[Token(Token = "0x6000BB5")]
	[Address(RVA = "0xA73AC0", Offset = "0xA73AC0", VA = "0xA73AC0")]
	private void AssignCharacterToController(Character character, Controller controller)
	{
	}

	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0xA73900", Offset = "0xA73900", VA = "0xA73900")]
	private bool IsSpawnerValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0xA73CC0", Offset = "0xA73CC0", VA = "0xA73CC0", Slot = "16")]
	protected virtual Vector3 GetOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0xA73590", Offset = "0xA73590", VA = "0xA73590")]
	private void CalculateSpawnPosition()
	{
	}

	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0xA73CC8", Offset = "0xA73CC8", VA = "0xA73CC8", Slot = "17")]
	protected virtual Vector3 CalculateGroundPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0xA735EC", Offset = "0xA735EC", VA = "0xA735EC")]
	private void CalculateSpawnRotation()
	{
	}

	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0xA73D70", Offset = "0xA73D70", VA = "0xA73D70")]
	public GameObject GetFirstSpawnedObject()
	{
		return null;
	}

	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0xA73DF0", Offset = "0xA73DF0", VA = "0xA73DF0")]
	private void OnDeath(object sender, Character.DeathEvent args)
	{
	}

	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0xA73E58", Offset = "0xA73E58", VA = "0xA73E58")]
	public Spawner()
	{
	}
}
