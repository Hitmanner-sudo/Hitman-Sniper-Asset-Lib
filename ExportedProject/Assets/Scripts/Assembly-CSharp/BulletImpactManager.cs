using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20007CE")]
public static class BulletImpactManager
{
	[Token(Token = "0x20007CF")]
	private class BulletImpact
	{
		[Token(Token = "0x20007D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5962BC", Offset = "0x5962BC")]
		private sealed class _003CFadeOut_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002BB7")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4002BB8")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4002BB9")]
			[FieldOffset(Offset = "0x20")]
			public BulletImpact _003C_003E4__this;

			[Token(Token = "0x4002BBA")]
			[FieldOffset(Offset = "0x28")]
			private Material _003Cmaterial_003E5__2;

			[Token(Token = "0x4002BBB")]
			[FieldOffset(Offset = "0x30")]
			private Color _003Ccolor_003E5__3;

			[Token(Token = "0x1700069E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6003356")]
				[Address(RVA = "0xA45574", Offset = "0xA45574", VA = "0xA45574", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700069F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6003358")]
				[Address(RVA = "0xA455BC", Offset = "0xA455BC", VA = "0xA455BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6003353")]
			[Address(RVA = "0xA45330", Offset = "0xA45330", VA = "0xA45330")]
			[DebuggerHidden]
			public _003CFadeOut_003Ed__22(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6003354")]
			[Address(RVA = "0xA4535C", Offset = "0xA4535C", VA = "0xA4535C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6003355")]
			[Address(RVA = "0xA45360", Offset = "0xA45360", VA = "0xA45360", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6003357")]
			[Address(RVA = "0xA4557C", Offset = "0xA4557C", VA = "0xA4557C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4002BAF")]
		[FieldOffset(Offset = "0x10")]
		private readonly ObjectPool<BulletImpact> _pool;

		[Token(Token = "0x4002BB0")]
		[FieldOffset(Offset = "0x18")]
		public GameObject Instance;

		[Token(Token = "0x4002BB1")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BAD5C", Offset = "0x5BAD5C")]
		private Transform _003CCachedTransform_003Ek__BackingField;

		[Token(Token = "0x4002BB2")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BAD6C", Offset = "0x5BAD6C")]
		private Renderer _003CCachedRenderer_003Ek__BackingField;

		[Token(Token = "0x4002BB3")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BAD7C", Offset = "0x5BAD7C")]
		private BulletImpactHook _003CCachedMonoBehaviour_003Ek__BackingField;

		[Token(Token = "0x4002BB4")]
		[FieldOffset(Offset = "0x38")]
		private readonly Material _prefabMaterial;

		[Token(Token = "0x4002BB5")]
		[FieldOffset(Offset = "0x40")]
		private readonly GameObject _impactPrefab;

		[Token(Token = "0x4002BB6")]
		[FieldOffset(Offset = "0x48")]
		public bool Fading;

		[Token(Token = "0x1700069A")]
		public ObjectPool<BulletImpact> Pool
		{
			[Token(Token = "0x6003348")]
			[Address(RVA = "0x85FD40", Offset = "0x85FD40", VA = "0x85FD40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069B")]
		private Transform CachedTransform
		{
			[Token(Token = "0x6003349")]
			[Address(RVA = "0x85FD48", Offset = "0x85FD48", VA = "0x85FD48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622A00", Offset = "0x622A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600334A")]
			[Address(RVA = "0x85FD50", Offset = "0x85FD50", VA = "0x85FD50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622A10", Offset = "0x622A10")]
			set
			{
			}
		}

		[Token(Token = "0x1700069C")]
		private Renderer CachedRenderer
		{
			[Token(Token = "0x600334B")]
			[Address(RVA = "0x85FD58", Offset = "0x85FD58", VA = "0x85FD58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622A20", Offset = "0x622A20")]
			get
			{
				return null;
			}
			[Token(Token = "0x600334C")]
			[Address(RVA = "0x85FD60", Offset = "0x85FD60", VA = "0x85FD60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622A30", Offset = "0x622A30")]
			set
			{
			}
		}

		[Token(Token = "0x1700069D")]
		public BulletImpactHook CachedMonoBehaviour
		{
			[Token(Token = "0x600334D")]
			[Address(RVA = "0x85FD68", Offset = "0x85FD68", VA = "0x85FD68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622A40", Offset = "0x622A40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600334E")]
			[Address(RVA = "0x85FD70", Offset = "0x85FD70", VA = "0x85FD70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x622A50", Offset = "0x622A50")]
			private set
			{
			}
		}

		[Token(Token = "0x600334F")]
		[Address(RVA = "0x85FC68", Offset = "0x85FC68", VA = "0x85FC68")]
		public BulletImpact(GameObject impactPrefab)
		{
		}

		[Token(Token = "0x6003350")]
		[Address(RVA = "0x85FD78", Offset = "0x85FD78", VA = "0x85FD78")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x6003351")]
		[Address(RVA = "0x85FE80", Offset = "0x85FE80", VA = "0x85FE80")]
		public void SetPosition(Transform parent, Vector3 position, Vector3 normal)
		{
		}

		[Token(Token = "0x6003352")]
		[Address(RVA = "0x860010", Offset = "0x860010", VA = "0x860010")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622A60", Offset = "0x622A60")]
		public IEnumerator FadeOut()
		{
			return null;
		}
	}

	[Token(Token = "0x20007D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5962CC", Offset = "0x5962CC")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4002BBC")]
		[FieldOffset(Offset = "0x10")]
		public GameObject prefab;

		[Token(Token = "0x6003359")]
		[Address(RVA = "0x85FC00", Offset = "0x85FC00", VA = "0x85FC00")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600335A")]
		[Address(RVA = "0x85FC08", Offset = "0x85FC08", VA = "0x85FC08")]
		internal BulletImpact _003CSpawn_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x4002BAE")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<GameObject, ObjectPool<BulletImpact>> _bulletPools;

	[Token(Token = "0x17000699")]
	private static bool IsInitialized
	{
		[Token(Token = "0x6003343")]
		[Address(RVA = "0xA86524", Offset = "0xA86524", VA = "0xA86524")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003344")]
	[Address(RVA = "0xA83050", Offset = "0xA83050", VA = "0xA83050")]
	public static void Spawn(BulletData bulletData, Collider surfaceCollider, Vector3 position, Vector3 normal, Transform parent)
	{
	}

	[Token(Token = "0x6003345")]
	[Address(RVA = "0xA86578", Offset = "0xA86578", VA = "0xA86578")]
	private static void Spawn(Vector3 position, Vector3 normal, Transform parent, GameObject prefab)
	{
	}

	[Token(Token = "0x6003346")]
	[Address(RVA = "0xA86A48", Offset = "0xA86A48", VA = "0xA86A48")]
	private static void FadeOut(BulletImpact hole)
	{
	}

	[Token(Token = "0x6003347")]
	[Address(RVA = "0xA86B3C", Offset = "0xA86B3C", VA = "0xA86B3C")]
	private static void OnSceneUnloading(object sender, EventArgs eventArgs)
	{
	}
}
