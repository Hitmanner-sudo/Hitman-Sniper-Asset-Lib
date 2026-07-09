using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology;
using Technology.Core.Common;
using UnityEngine;

[Serializable]
[Token(Token = "0x200036E")]
public class Bullet
{
	[Token(Token = "0x200036F")]
	public struct Hit
	{
		[Token(Token = "0x400130D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DamageCollider Object;

		[Token(Token = "0x400130E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public RaycastHit Contact;

		[Token(Token = "0x400130F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int HitIndex;
	}

	[Token(Token = "0x2000370")]
	public class BulletHitArgs : EventArgs
	{
		[Token(Token = "0x4001310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Damage.Hit> History;

		[Token(Token = "0x6001504")]
		[Address(RVA = "0x85FB5C", Offset = "0x85FB5C", VA = "0x85FB5C")]
		public BulletHitArgs()
		{
		}
	}

	[Token(Token = "0x2000371")]
	public class BulletDiedArgs : EventArgs
	{
		[Token(Token = "0x4001311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4001312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Damage.Hit> History;

		[Token(Token = "0x4001313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ShotMissed;

		[Token(Token = "0x6001505")]
		[Address(RVA = "0x85FAF8", Offset = "0x85FAF8", VA = "0x85FAF8")]
		public BulletDiedArgs()
		{
		}
	}

	[Token(Token = "0x2000372")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x5934A4", Offset = "0x5934A4")]
	private struct ListSlice<T>
	{
		[Token(Token = "0x4001314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> _list;

		[Token(Token = "0x4001315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _startIdx;

		[Token(Token = "0x4001316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _endIdx;

		[Token(Token = "0x4001317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _count;

		[Token(Token = "0x1700031B")]
		public int Count
		{
			[Token(Token = "0x6001506")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700031C")]
		public T Item
		{
			[Token(Token = "0x6001507")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6001508")]
			set
			{
			}
		}

		[Token(Token = "0x6001509")]
		public ListSlice(List<T> list, int startIdx, int endIdx)
		{
		}

		[Token(Token = "0x600150A")]
		private void ThrowIfInvalid(int idx)
		{
		}
	}

	[Token(Token = "0x2000373")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5934DC", Offset = "0x5934DC")]
	private sealed class _003C_003Ec__DisplayClass64_0
	{
		[Token(Token = "0x4001318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Damage.Hit> colliderHistory;

		[Token(Token = "0x4001319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Bullet _003C_003E4__this;

		[Token(Token = "0x400131A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject projectile;

		[Token(Token = "0x400131B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Utils.CreateArgs<BulletHitArgs> _003C_003E9__1;

		[Token(Token = "0x600150B")]
		[Address(RVA = "0x92B054", Offset = "0x92B054", VA = "0x92B054")]
		public _003C_003Ec__DisplayClass64_0()
		{
		}

		[Token(Token = "0x600150C")]
		[Address(RVA = "0x92B05C", Offset = "0x92B05C", VA = "0x92B05C")]
		internal BulletHitArgs _003CBulletTravel_003Eb__1()
		{
			return null;
		}

		[Token(Token = "0x600150D")]
		[Address(RVA = "0x92B0C8", Offset = "0x92B0C8", VA = "0x92B0C8")]
		internal BulletDiedArgs _003CBulletTravel_003Eb__0()
		{
			return null;
		}

		[Token(Token = "0x600150E")]
		[Address(RVA = "0x92B24C", Offset = "0x92B24C", VA = "0x92B24C")]
		internal void _003CBulletTravel_003Eb__3()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000374")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5934EC", Offset = "0x5934EC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400131C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400131D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Damage.Hit, bool> _003C_003E9__64_2;

		[Token(Token = "0x400131E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<RaycastHit> _003C_003E9__80_0;

		[Token(Token = "0x6001510")]
		[Address(RVA = "0x92AF68", Offset = "0x92AF68", VA = "0x92AF68")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001511")]
		[Address(RVA = "0x92AF70", Offset = "0x92AF70", VA = "0x92AF70")]
		internal bool _003CBulletTravel_003Eb__64_2(Damage.Hit hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6001512")]
		[Address(RVA = "0x92AFE4", Offset = "0x92AFE4", VA = "0x92AFE4")]
		internal int _003CSimulateBallistics_003Eb__80_0(RaycastHit a, RaycastHit b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000375")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5934FC", Offset = "0x5934FC")]
	private sealed class _003CBulletTravel_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400131F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Bullet _003C_003E4__this;

		[Token(Token = "0x4001322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass64_0 _003C_003E8__1;

		[Token(Token = "0x4001323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _003ClastRayPos_003E5__2;

		[Token(Token = "0x1700031D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001516")]
			[Address(RVA = "0x92BD58", Offset = "0x92BD58", VA = "0x92BD58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700031E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001518")]
			[Address(RVA = "0x92BDA0", Offset = "0x92BDA0", VA = "0x92BDA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001513")]
		[Address(RVA = "0x92B2F8", Offset = "0x92B2F8", VA = "0x92B2F8")]
		[DebuggerHidden]
		public _003CBulletTravel_003Ed__64(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001514")]
		[Address(RVA = "0x92B324", Offset = "0x92B324", VA = "0x92B324", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001515")]
		[Address(RVA = "0x92B328", Offset = "0x92B328", VA = "0x92B328", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001517")]
		[Address(RVA = "0x92BD60", Offset = "0x92BD60", VA = "0x92BD60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000376")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59350C", Offset = "0x59350C")]
	private sealed class _003C_003Ec__DisplayClass76_0
	{
		[Token(Token = "0x4001324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Hit hit;

		[Token(Token = "0x6001519")]
		[Address(RVA = "0x92B2B4", Offset = "0x92B2B4", VA = "0x92B2B4")]
		public _003C_003Ec__DisplayClass76_0()
		{
		}

		[Token(Token = "0x600151A")]
		[Address(RVA = "0x92B2BC", Offset = "0x92B2BC", VA = "0x92B2BC")]
		internal bool _003CCreateDamage_003Eb__0(BulletDamageDesc item)
		{
			return default(bool);
		}
	}

	[NonSerialized]
	[Token(Token = "0x40012EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Bullet LastBulletShot;

	[Token(Token = "0x40012F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject Spark;

	[Token(Token = "0x40012F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Projectile;

	[Token(Token = "0x40012F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> ProjectileEffects;

	[Token(Token = "0x40012F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float LifeTime;

	[NonSerialized]
	[Token(Token = "0x40012F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameMonoBehaviour Owner;

	[NonSerialized]
	[Token(Token = "0x40012F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Weapon WeaponShotFrom;

	[NonSerialized]
	[Token(Token = "0x40012F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public BulletData Data;

	[NonSerialized]
	[Token(Token = "0x40012F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public long ID;

	[NonSerialized]
	[Token(Token = "0x40012F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 Origin;

	[NonSerialized]
	[Token(Token = "0x40012F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 CurrentPosition;

	[NonSerialized]
	[Token(Token = "0x40012FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3 CurrentAcceleration;

	[NonSerialized]
	[Token(Token = "0x40012FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float Strength;

	[NonSerialized]
	[Token(Token = "0x40012FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Hit> Hits;

	[NonSerialized]
	[Token(Token = "0x40012FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool Stopped;

	[NonSerialized]
	[Token(Token = "0x40012FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	public bool WasFromHoldBreath;

	[NonSerialized]
	[Token(Token = "0x40012FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
	public bool WasFromMinZoom;

	[NonSerialized]
	[Token(Token = "0x4001300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
	public bool WasFromSplitShot;

	[Token(Token = "0x4001301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AIEmitter _emitter;

	[Token(Token = "0x4001302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 _currentVelocity;

	[Token(Token = "0x4001303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 _acceleration;

	[Token(Token = "0x4001304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float _elapsedTime;

	[Token(Token = "0x4001305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private LinkedList<HierarchicalCollision> _enteredColliders;

	[Token(Token = "0x4001306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private bool _isInstaBullet;

	[Token(Token = "0x4001307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private int _lifetimeFrames;

	[Token(Token = "0x4001308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int _frameStarted;

	[Token(Token = "0x4001309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Coroutine _travelCoroutine;

	[Token(Token = "0x17000313")]
	public Vector3 Direction
	{
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0xA817B8", Offset = "0xA817B8", VA = "0xA817B8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000314")]
	public float Speed
	{
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0xA817C4", Offset = "0xA817C4", VA = "0xA817C4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000315")]
	public int Damage
	{
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0xA817F8", Offset = "0xA817F8", VA = "0xA817F8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000316")]
	public float ImpactForce
	{
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0xA8182C", Offset = "0xA8182C", VA = "0xA8182C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000317")]
	public float Gravity
	{
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0xA81860", Offset = "0xA81860", VA = "0xA81860")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000318")]
	public float Drag
	{
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0xA81894", Offset = "0xA81894", VA = "0xA81894")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000319")]
	public float Radius
	{
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0xA818C8", Offset = "0xA818C8", VA = "0xA818C8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700031A")]
	private Vector3 Acceleration
	{
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0xA81908", Offset = "0xA81908", VA = "0xA81908")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0xA818FC", Offset = "0xA818FC", VA = "0xA818FC")]
		set
		{
		}
	}

	[Token(Token = "0x14000055")]
	public static event EventHandler OnBulletShot
	{
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0xA819E0", Offset = "0xA819E0", VA = "0xA819E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6171B4", Offset = "0x6171B4")]
		add
		{
		}
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0xA81AA0", Offset = "0xA81AA0", VA = "0xA81AA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6171C4", Offset = "0x6171C4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000056")]
	public static event EventHandler<BulletHitArgs> OnBulletHit
	{
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0xA81B60", Offset = "0xA81B60", VA = "0xA81B60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6171D4", Offset = "0x6171D4")]
		add
		{
		}
		[Token(Token = "0x60014E4")]
		[Address(RVA = "0xA81C20", Offset = "0xA81C20", VA = "0xA81C20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6171E4", Offset = "0x6171E4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000057")]
	public static event EventHandler<BulletDiedArgs> OnBulletDied
	{
		[Token(Token = "0x60014E5")]
		[Address(RVA = "0xA81CE0", Offset = "0xA81CE0", VA = "0xA81CE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6171F4", Offset = "0x6171F4")]
		add
		{
		}
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0xA81DA0", Offset = "0xA81DA0", VA = "0xA81DA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617204", Offset = "0x617204")]
		remove
		{
		}
	}

	[Token(Token = "0x60014D5")]
	[Address(RVA = "0xA813FC", Offset = "0xA813FC", VA = "0xA813FC")]
	public Bullet()
	{
	}

	[Token(Token = "0x60014D6")]
	[Address(RVA = "0xA814C0", Offset = "0xA814C0", VA = "0xA814C0", Slot = "1")]
	~Bullet()
	{
	}

	[Token(Token = "0x60014D7")]
	[Address(RVA = "0xA814D0", Offset = "0xA814D0", VA = "0xA814D0")]
	public Bullet Instantiate(GameMonoBehaviour owner, BulletData bulletData)
	{
		return null;
	}

	[Token(Token = "0x60014E7")]
	[Address(RVA = "0xA81E60", Offset = "0xA81E60", VA = "0xA81E60")]
	public void Reset(Vector3 origin, Vector3 direction, bool instaBullet)
	{
	}

	[Token(Token = "0x60014E8")]
	[Address(RVA = "0xA81FB4", Offset = "0xA81FB4", VA = "0xA81FB4")]
	public void Shoot(Vector3 origin, Vector3 direction, bool instaBullet)
	{
	}

	[Token(Token = "0x60014E9")]
	[Address(RVA = "0xA821D8", Offset = "0xA821D8", VA = "0xA821D8")]
	private void OnBulletDiedInternal(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60014EA")]
	[Address(RVA = "0xA822B4", Offset = "0xA822B4", VA = "0xA822B4")]
	private void OnGameEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60014EB")]
	[Address(RVA = "0xA823FC", Offset = "0xA823FC", VA = "0xA823FC")]
	public void AddExtraBulletProperties()
	{
	}

	[Token(Token = "0x60014EC")]
	[Address(RVA = "0xA8216C", Offset = "0xA8216C", VA = "0xA8216C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x617214", Offset = "0x617214")]
	private IEnumerator BulletTravel()
	{
		return null;
	}

	[Token(Token = "0x60014ED")]
	[Address(RVA = "0xA8249C", Offset = "0xA8249C", VA = "0xA8249C")]
	public static bool IsEnemyObject(GameMonoBehaviour owner, DamageCollider hitObjectDamageCollider)
	{
		return default(bool);
	}

	[Token(Token = "0x60014EE")]
	[Address(RVA = "0xA82588", Offset = "0xA82588", VA = "0xA82588")]
	public static bool IsEnemyObject(GameObject ownerGO, GameObject hitObjectGO)
	{
		return default(bool);
	}

	[Token(Token = "0x60014EF")]
	[Address(RVA = "0xA825FC", Offset = "0xA825FC", VA = "0xA825FC")]
	private static Faction GetObjectFaction(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60014F0")]
	[Address(RVA = "0xA826F8", Offset = "0xA826F8", VA = "0xA826F8")]
	private bool NeedToDetonate(Hit hit)
	{
		return default(bool);
	}

	[Token(Token = "0x60014F1")]
	[Address(RVA = "0xA827D8", Offset = "0xA827D8", VA = "0xA827D8")]
	private void SpawnGameObject(Hit hit, GameObject spawnOnImpactObject, Action<GameObject, long, Hit> preEnabledFunction, Action<GameObject, long, Hit> postEnabledFunction)
	{
	}

	[Token(Token = "0x60014F2")]
	[Address(RVA = "0xA82AB8", Offset = "0xA82AB8", VA = "0xA82AB8")]
	private void SpawnOnImpact(Hit hit)
	{
	}

	[Token(Token = "0x60014F3")]
	[Address(RVA = "0xA82BCC", Offset = "0xA82BCC", VA = "0xA82BCC")]
	private void SpawnOnStop(Hit hit)
	{
	}

	[Token(Token = "0x60014F4")]
	[Address(RVA = "0xA82CEC", Offset = "0xA82CEC", VA = "0xA82CEC")]
	private void EnvironmentHit(List<Damage.Hit> colliderHistory, Hit hit, ref AIMemento memento)
	{
	}

	[Token(Token = "0x60014F5")]
	[Address(RVA = "0xA834E4", Offset = "0xA834E4", VA = "0xA834E4")]
	private void Detonate(List<Damage.Hit> colliderHistory, Hit hit, out AIMemento memento)
	{
	}

	[Token(Token = "0x60014F6")]
	[Address(RVA = "0xA83940", Offset = "0xA83940", VA = "0xA83940")]
	private void ColliderHit(List<Damage.Hit> colliderHistory, Hit hit, ref AIMemento memento)
	{
	}

	[Token(Token = "0x60014F7")]
	[Address(RVA = "0xA83AB0", Offset = "0xA83AB0", VA = "0xA83AB0")]
	private void ApplyFreezeAndKillDamage(List<Damage.Hit> colliderHistory, Hit hit, ThirdPersonCharacter thirdPersonCharacter)
	{
	}

	[Token(Token = "0x60014F8")]
	[Address(RVA = "0xA83E80", Offset = "0xA83E80", VA = "0xA83E80")]
	public Damage CreateDamage(List<Damage.Hit> colliderHistory, Hit hit)
	{
		return null;
	}

	[Token(Token = "0x60014F9")]
	[Address(RVA = "0xA840AC", Offset = "0xA840AC", VA = "0xA840AC")]
	public Damage CreateSimpleDamage([Optional] DamageCollider damageCollider)
	{
		return null;
	}

	[Token(Token = "0x60014FA")]
	[Address(RVA = "0xA83BF8", Offset = "0xA83BF8", VA = "0xA83BF8")]
	private void ApplyDefaultDamage(List<Damage.Hit> colliderHistory, Hit hit, ThirdPersonCharacter thirdPersonCharacter, ref AIMemento memento)
	{
	}

	[Token(Token = "0x60014FB")]
	[Address(RVA = "0xA84384", Offset = "0xA84384", VA = "0xA84384")]
	private RaycastHit[] CastCollision(Vector3 origin, Vector3 direction, float distance, int layermask)
	{
		return null;
	}

	[Token(Token = "0x60014FC")]
	[Address(RVA = "0xA843C0", Offset = "0xA843C0", VA = "0xA843C0")]
	private Vector3 SimulateBallistics(float deltaTime, ref Vector3 lastRayPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60014FD")]
	[Address(RVA = "0xA85540", Offset = "0xA85540", VA = "0xA85540")]
	private void PrepareCharacterDismemberment(List<RaycastHit> subHitsList)
	{
	}

	[Token(Token = "0x60014FE")]
	[Address(RVA = "0xA85318", Offset = "0xA85318", VA = "0xA85318")]
	private void GuidedArrowVelocityAdjustment()
	{
	}

	[Token(Token = "0x60014FF")]
	[Address(RVA = "0xA85428", Offset = "0xA85428", VA = "0xA85428")]
	private Vector3 GuidedArrowPositionAdjustment(Vector3 newPosition, float deltaTime)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001500")]
	[Address(RVA = "0xA832E0", Offset = "0xA832E0", VA = "0xA832E0")]
	private void ApplyImpulse(Hit hit)
	{
	}

	[Token(Token = "0x6001501")]
	[Address(RVA = "0xA852CC", Offset = "0xA852CC", VA = "0xA852CC")]
	private bool HasLifetimeExpired()
	{
		return default(bool);
	}

	[Token(Token = "0x6001502")]
	[Address(RVA = "0xA8585C", Offset = "0xA8585C", VA = "0xA8585C")]
	private void PrioritizeHeadshotsBetweenEnvironmentHits(List<Hit> hits)
	{
	}

	[Token(Token = "0x6001503")]
	[Address(RVA = "0xA85A1C", Offset = "0xA85A1C", VA = "0xA85A1C")]
	private void PrioritizeHeadshotInSlice(ListSlice<Hit> hits)
	{
	}
}
