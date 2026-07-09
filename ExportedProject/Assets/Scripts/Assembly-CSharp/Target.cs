using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20002AB")]
public class Target : GameMonoBehaviour
{
	[Token(Token = "0x20002AC")]
	public enum TargetTypeEnum
	{
		[Token(Token = "0x4000F0B")]
		DontCare = 0,
		[Token(Token = "0x4000F0C")]
		Primary = 1,
		[Token(Token = "0x4000F0D")]
		Secondary = 2,
		[Token(Token = "0x4000F0E")]
		DontDamage = 3,
		[Token(Token = "0x4000F0F")]
		Tertiary = 4
	}

	[Token(Token = "0x20002AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5930D0", Offset = "0x5930D0")]
	private sealed class _003CMeasureVelocity_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F10")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F11")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F12")]
		[FieldOffset(Offset = "0x20")]
		public Target _003C_003E4__this;

		[Token(Token = "0x17000286")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600106B")]
			[Address(RVA = "0xA5546C", Offset = "0xA5546C", VA = "0xA5546C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000287")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600106D")]
			[Address(RVA = "0xA554B4", Offset = "0xA554B4", VA = "0xA554B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001068")]
		[Address(RVA = "0xA5526C", Offset = "0xA5526C", VA = "0xA5526C")]
		[DebuggerHidden]
		public _003CMeasureVelocity_003Ed__42(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001069")]
		[Address(RVA = "0xA55298", Offset = "0xA55298", VA = "0xA55298", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600106A")]
		[Address(RVA = "0xA5529C", Offset = "0xA5529C", VA = "0xA5529C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600106C")]
		[Address(RVA = "0xA55474", Offset = "0xA55474", VA = "0xA55474", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20002AE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5930E0", Offset = "0x5930E0")]
	private sealed class _003CDelayedUndetectedKillCheck_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F13")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F14")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F15")]
		[FieldOffset(Offset = "0x20")]
		public Target _003C_003E4__this;

		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x28")]
		public TargetDamagedEventArgs e;

		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x30")]
		private float _003Cdelay_003E5__2;

		[Token(Token = "0x17000288")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001071")]
			[Address(RVA = "0xA5521C", Offset = "0xA5521C", VA = "0xA5521C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000289")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001073")]
			[Address(RVA = "0xA55264", Offset = "0xA55264", VA = "0xA55264", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600106E")]
		[Address(RVA = "0xA54E8C", Offset = "0xA54E8C", VA = "0xA54E8C")]
		[DebuggerHidden]
		public _003CDelayedUndetectedKillCheck_003Ed__43(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600106F")]
		[Address(RVA = "0xA54EB8", Offset = "0xA54EB8", VA = "0xA54EB8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001070")]
		[Address(RVA = "0xA54EBC", Offset = "0xA54EBC", VA = "0xA54EBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001072")]
		[Address(RVA = "0xA55224", Offset = "0xA55224", VA = "0xA55224", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20002AF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5930F0", Offset = "0x5930F0")]
	private sealed class _003C_003Ec__DisplayClass45_0
	{
		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x10")]
		public TargetDamagedEventArgs e;

		[Token(Token = "0x6001074")]
		[Address(RVA = "0xA54E40", Offset = "0xA54E40", VA = "0xA54E40")]
		public _003C_003Ec__DisplayClass45_0()
		{
		}

		[Token(Token = "0x6001075")]
		[Address(RVA = "0xA54E48", Offset = "0xA54E48", VA = "0xA54E48")]
		internal bool _003CUpdateStats_003Eb__0(long r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000EFF")]
	[FieldOffset(Offset = "0x48")]
	public TargetTypeEnum TargetType;

	[Token(Token = "0x4000F00")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3B84", Offset = "0x5B3B84")]
	private DropList _003CDropList_003Ek__BackingField;

	[Token(Token = "0x4000F01")]
	[FieldOffset(Offset = "0x58")]
	public RogueData RogueDataObject;

	[Token(Token = "0x4000F02")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3B94", Offset = "0x5B3B94")]
	private Character _003CCharacterComponent_003Ek__BackingField;

	[Token(Token = "0x4000F03")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3BA4", Offset = "0x5B3BA4")]
	private Health _003CHealthComponent_003Ek__BackingField;

	[Token(Token = "0x4000F04")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3BB4", Offset = "0x5B3BB4")]
	private Memory _003CMemoryComponent_003Ek__BackingField;

	[Token(Token = "0x4000F05")]
	[FieldOffset(Offset = "0x78")]
	private CharacterEmitter _emitter;

	[Token(Token = "0x4000F06")]
	[FieldOffset(Offset = "0x80")]
	protected Vector3 _lastPosition;

	[Token(Token = "0x4000F07")]
	[FieldOffset(Offset = "0x8C")]
	protected float _lastUpdateTime;

	[NonSerialized]
	[Token(Token = "0x4000F08")]
	[FieldOffset(Offset = "0x90")]
	public float Velocity;

	[Token(Token = "0x4000F09")]
	[FieldOffset(Offset = "0x98")]
	private Coroutine _velocityCoroutine;

	[Token(Token = "0x17000281")]
	public bool RewardKill
	{
		[Token(Token = "0x6001051")]
		[Address(RVA = "0xB533DC", Offset = "0xB533DC", VA = "0xB533DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000282")]
	public DropList DropList
	{
		[Token(Token = "0x6001052")]
		[Address(RVA = "0xB53408", Offset = "0xB53408", VA = "0xB53408")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615A34", Offset = "0x615A34")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001053")]
		[Address(RVA = "0xB53410", Offset = "0xB53410", VA = "0xB53410")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615A44", Offset = "0x615A44")]
		set
		{
		}
	}

	[Token(Token = "0x17000283")]
	public Character CharacterComponent
	{
		[Token(Token = "0x6001054")]
		[Address(RVA = "0xB53418", Offset = "0xB53418", VA = "0xB53418")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615A54", Offset = "0x615A54")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001055")]
		[Address(RVA = "0xB53420", Offset = "0xB53420", VA = "0xB53420")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615A64", Offset = "0x615A64")]
		private set
		{
		}
	}

	[Token(Token = "0x17000284")]
	public Health HealthComponent
	{
		[Token(Token = "0x6001056")]
		[Address(RVA = "0xB53428", Offset = "0xB53428", VA = "0xB53428")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615A74", Offset = "0x615A74")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001057")]
		[Address(RVA = "0xB53430", Offset = "0xB53430", VA = "0xB53430")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615A84", Offset = "0x615A84")]
		private set
		{
		}
	}

	[Token(Token = "0x17000285")]
	public Memory MemoryComponent
	{
		[Token(Token = "0x6001058")]
		[Address(RVA = "0xB53438", Offset = "0xB53438", VA = "0xB53438")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615A94", Offset = "0x615A94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001059")]
		[Address(RVA = "0xB53440", Offset = "0xB53440", VA = "0xB53440")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615AA4", Offset = "0x615AA4")]
		private set
		{
		}
	}

	[Token(Token = "0x14000048")]
	public static event EventHandler<TargetDamagedEventArgs> TargetDamaged
	{
		[Token(Token = "0x600104B")]
		[Address(RVA = "0xB52F64", Offset = "0xB52F64", VA = "0xB52F64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6159D4", Offset = "0x6159D4")]
		add
		{
		}
		[Token(Token = "0x600104C")]
		[Address(RVA = "0xB53020", Offset = "0xB53020", VA = "0xB53020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6159E4", Offset = "0x6159E4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000049")]
	public static event EventHandler<TargetDamagedEventArgs> TargetKilledUndetected
	{
		[Token(Token = "0x600104D")]
		[Address(RVA = "0xB530DC", Offset = "0xB530DC", VA = "0xB530DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6159F4", Offset = "0x6159F4")]
		add
		{
		}
		[Token(Token = "0x600104E")]
		[Address(RVA = "0xB5319C", Offset = "0xB5319C", VA = "0xB5319C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615A04", Offset = "0x615A04")]
		remove
		{
		}
	}

	[Token(Token = "0x1400004A")]
	public static event EventHandler<TargetDamagedEventArgs> TargetKilled
	{
		[Token(Token = "0x600104F")]
		[Address(RVA = "0xB5325C", Offset = "0xB5325C", VA = "0xB5325C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615A14", Offset = "0x615A14")]
		add
		{
		}
		[Token(Token = "0x6001050")]
		[Address(RVA = "0xB5331C", Offset = "0xB5331C", VA = "0xB5331C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615A24", Offset = "0x615A24")]
		remove
		{
		}
	}

	[Token(Token = "0x600105A")]
	[Address(RVA = "0xB53448", Offset = "0xB53448", VA = "0xB53448", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600105B")]
	[Address(RVA = "0xB534CC", Offset = "0xB534CC", VA = "0xB534CC", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600105C")]
	[Address(RVA = "0xB536C4", Offset = "0xB536C4", VA = "0xB536C4")]
	private void OnPreTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x600105D")]
	[Address(RVA = "0xB53F44", Offset = "0xB53F44", VA = "0xB53F44")]
	private void OnDied(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x600105E")]
	[Address(RVA = "0xB54024", Offset = "0xB54024", VA = "0xB54024", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600105F")]
	[Address(RVA = "0xB5422C", Offset = "0xB5422C", VA = "0xB5422C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001060")]
	[Address(RVA = "0xB542D8", Offset = "0xB542D8", VA = "0xB542D8", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001061")]
	[Address(RVA = "0xB5426C", Offset = "0xB5426C", VA = "0xB5426C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x615AB4", Offset = "0x615AB4")]
	private IEnumerator MeasureVelocity()
	{
		return null;
	}

	[Token(Token = "0x6001062")]
	[Address(RVA = "0xB53ECC", Offset = "0xB53ECC", VA = "0xB53ECC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x615B14", Offset = "0x615B14")]
	private IEnumerator DelayedUndetectedKillCheck(TargetDamagedEventArgs e)
	{
		return null;
	}

	[Token(Token = "0x6001063")]
	[Address(RVA = "0xB5436C", Offset = "0xB5436C", VA = "0xB5436C")]
	private AnimationConfig.MovementSpeed GetMovementSpeedClass()
	{
		return default(AnimationConfig.MovementSpeed);
	}

	[Token(Token = "0x6001064")]
	[Address(RVA = "0xB538C4", Offset = "0xB538C4", VA = "0xB538C4")]
	private void UpdateStats(TargetDamagedEventArgs e)
	{
	}

	[Token(Token = "0x6001065")]
	[Address(RVA = "0xB543F0", Offset = "0xB543F0", VA = "0xB543F0")]
	public bool IsSpeedClassInArray(int[] array)
	{
		return default(bool);
	}

	[Token(Token = "0x6001066")]
	[Address(RVA = "0xB54454", Offset = "0xB54454", VA = "0xB54454")]
	public bool IsSpeedClassInArray(AnimationConfig.MovementSpeed[] array)
	{
		return default(bool);
	}

	[Token(Token = "0x6001067")]
	[Address(RVA = "0xB544B8", Offset = "0xB544B8", VA = "0xB544B8")]
	public Target()
	{
	}
}
