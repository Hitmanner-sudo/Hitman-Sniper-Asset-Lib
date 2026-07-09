using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000D8")]
public class Waypoint : Attractor
{
	[Token(Token = "0x20000D9")]
	public class WaypointEventArgs : EventArgs
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B05D4", Offset = "0x5B05D4")]
		private Waypoint _003CWaypoint_003Ek__BackingField;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B05E4", Offset = "0x5B05E4")]
		private AIController _003CAI_003Ek__BackingField;

		[Token(Token = "0x17000131")]
		public Waypoint Waypoint
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0xA41D2C", Offset = "0xA41D2C", VA = "0xA41D2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6121B0", Offset = "0x6121B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000671")]
			[Address(RVA = "0xA41D34", Offset = "0xA41D34", VA = "0xA41D34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6121C0", Offset = "0x6121C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public AIController AI
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0xA41D3C", Offset = "0xA41D3C", VA = "0xA41D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6121D0", Offset = "0x6121D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0xA41D44", Offset = "0xA41D44", VA = "0xA41D44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6121E0", Offset = "0x6121E0")]
			set
			{
			}
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xA41C50", Offset = "0xA41C50", VA = "0xA41C50")]
		public WaypointEventArgs()
		{
		}
	}

	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5923F8", Offset = "0x5923F8")]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Waypoint _003C_003E4__this;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AIController ai;

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xA41BD8", Offset = "0xA41BD8", VA = "0xA41BD8")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xA41BE0", Offset = "0xA41BE0", VA = "0xA41BE0")]
		internal WaypointEventArgs _003CStartUsing_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592408", Offset = "0x592408")]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Waypoint _003C_003E4__this;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AIController ai;

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xA41CB4", Offset = "0xA41CB4", VA = "0xA41CB4")]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xA41CBC", Offset = "0xA41CBC", VA = "0xA41CBC")]
		internal WaypointEventArgs _003CStopUsing_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float StopTime;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public AnimationConfig.IdleType IdleType;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "ClampAttribute", RVA = "0x5B0574", Offset = "0x5B0574")]
	public float ReachRadius;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float RandomRadiusRange;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public AnimationConfig.MovementSpeed Speed;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public bool PrecisePositioning;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
	public bool Unspawn;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBE")]
	public bool ShowProgress;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public VisionZone VisionZone;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<AIController> _reached;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private string _taskID;

	[Token(Token = "0x17000130")]
	public string TaskID
	{
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x97E6F8", Offset = "0x97E6F8", VA = "0x97E6F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000009")]
	public event Action<Waypoint> OnDestroyed
	{
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x97E5B8", Offset = "0x97E5B8", VA = "0x97E5B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612130", Offset = "0x612130")]
		add
		{
		}
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x97E658", Offset = "0x97E658", VA = "0x97E658")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612140", Offset = "0x612140")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event EventHandler<WaypointEventArgs> ReachedCallback
	{
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x97E700", Offset = "0x97E700", VA = "0x97E700")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612150", Offset = "0x612150")]
		add
		{
		}
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x97E7A0", Offset = "0x97E7A0", VA = "0x97E7A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612160", Offset = "0x612160")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public static event EventHandler<WaypointEventArgs> OnStartUsing
	{
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x97E840", Offset = "0x97E840", VA = "0x97E840")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612170", Offset = "0x612170")]
		add
		{
		}
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x97E8FC", Offset = "0x97E8FC", VA = "0x97E8FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612180", Offset = "0x612180")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public static event EventHandler<WaypointEventArgs> OnStopUsing
	{
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x97E9B8", Offset = "0x97E9B8", VA = "0x97E9B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612190", Offset = "0x612190")]
		add
		{
		}
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x97EA78", Offset = "0x97EA78", VA = "0x97EA78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6121A0", Offset = "0x6121A0")]
		remove
		{
		}
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x97EB38", Offset = "0x97EB38", VA = "0x97EB38", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x97EC04", Offset = "0x97EC04", VA = "0x97EC04", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x97EC60", Offset = "0x97EC60", VA = "0x97EC60", Slot = "20")]
	public override void StartUsing(AIController ai)
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x97ED90", Offset = "0x97ED90", VA = "0x97ED90")]
	public void MoveToWaypoint(AIController ai, [Optional] Vector3? startPosition)
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x97EE1C", Offset = "0x97EE1C", VA = "0x97EE1C", Slot = "21")]
	public override void StopUsing(AIController ai)
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x97EF78", Offset = "0x97EF78", VA = "0x97EF78")]
	protected void StopTask(AIController ai)
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x97F0AC", Offset = "0x97F0AC", VA = "0x97F0AC", Slot = "22")]
	public override bool IsUsing(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x97F154", Offset = "0x97F154", VA = "0x97F154", Slot = "27")]
	public virtual void OnReached(AIController ai)
	{
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x97EFA4", Offset = "0x97EFA4", VA = "0x97EFA4")]
	private void ResetDefaultVision(AIController ai)
	{
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x97F348", Offset = "0x97F348", VA = "0x97F348", Slot = "28")]
	public virtual AnimationConfig.IdleType GetIdleType()
	{
		return default(AnimationConfig.IdleType);
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x97F350", Offset = "0x97F350", VA = "0x97F350", Slot = "18")]
	public override Vector3 GetDestination(AIController ai)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x97F4B8", Offset = "0x97F4B8", VA = "0x97F4B8")]
	public Waypoint()
	{
	}
}
