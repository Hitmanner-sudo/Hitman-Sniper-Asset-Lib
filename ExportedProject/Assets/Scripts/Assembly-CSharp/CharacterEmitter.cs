using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000143")]
public class CharacterEmitter : AIVisionEmitter
{
	[Token(Token = "0x2000144")]
	public class MurderedVictimFoundArgs : EventArgs
	{
		[Token(Token = "0x40006EC")]
		[FieldOffset(Offset = "0x10")]
		public Memory Memory;

		[Token(Token = "0x40006ED")]
		[FieldOffset(Offset = "0x18")]
		public string Description;

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x861BCC", Offset = "0x861BCC", VA = "0x861BCC")]
		public MurderedVictimFoundArgs()
		{
		}
	}

	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59260C", Offset = "0x59260C")]
	private sealed class _003CDelayWasSeen_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006EE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40006EF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40006F0")]
		[FieldOffset(Offset = "0x20")]
		public float delayTime;

		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x28")]
		public AIVisionSensor sensor;

		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x30")]
		public CharacterEmitter _003C_003E4__this;

		[Token(Token = "0x40006F3")]
		[FieldOffset(Offset = "0x38")]
		public string description;

		[Token(Token = "0x1700016F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x861C30", Offset = "0x861C30", VA = "0x861C30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000170")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x861C78", Offset = "0x861C78", VA = "0x861C78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x861970", Offset = "0x861970", VA = "0x861970")]
		[DebuggerHidden]
		public _003CDelayWasSeen_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x86199C", Offset = "0x86199C", VA = "0x86199C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x8619A0", Offset = "0x8619A0", VA = "0x8619A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x861C38", Offset = "0x861C38", VA = "0x861C38", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	public ThreatLevel AreaThreatLevel;

	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x70")]
	private ThirdPersonCharacter _character;

	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x78")]
	private bool _murderedVictimFound;

	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0x7C")]
	private float _timeSinceDeath;

	[Token(Token = "0x40006E9")]
	private const float DELAY_BEFORE_SEEN = 1f;

	[Token(Token = "0x40006EA")]
	private const float DELAY_FOR_KILL_WITNESS = 2f;

	[Token(Token = "0x1700016C")]
	public bool MurderedVictimFound
	{
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xAFB6B4", Offset = "0xAFB6B4", VA = "0xAFB6B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700016D")]
	public override Faction Faction
	{
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xAFBA98", Offset = "0xAFBA98", VA = "0xAFBA98", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700016E")]
	public override Vector3 Velocity
	{
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xAFC1C0", Offset = "0xAFC1C0", VA = "0xAFC1C0", Slot = "18")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x14000013")]
	public static event EventHandler<MurderedVictimFoundArgs> OnMurderedVictimFound
	{
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xAFB6BC", Offset = "0xAFB6BC", VA = "0xAFB6BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6128A8", Offset = "0x6128A8")]
		add
		{
		}
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xAFB778", Offset = "0xAFB778", VA = "0xAFB778")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6128B8", Offset = "0x6128B8")]
		remove
		{
		}
	}

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0xAFB834", Offset = "0xAFB834", VA = "0xAFB834", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0xAFB910", Offset = "0xAFB910", VA = "0xAFB910", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0xAFBB20", Offset = "0xAFBB20", VA = "0xAFBB20", Slot = "22")]
	public override void WasSeen(AIVisionSensor sensor)
	{
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0xAFBD78", Offset = "0xAFBD78", VA = "0xAFBD78")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6128C8", Offset = "0x6128C8")]
	private IEnumerator DelayWasSeen(AIVisionSensor sensor, string description, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60008B6")]
	[Address(RVA = "0xAFBE08", Offset = "0xAFBE08", VA = "0xAFBE08", Slot = "19")]
	public override ThreatLevel GetVisibleThreatLevel(AIVisionSensor sensor)
	{
		return default(ThreatLevel);
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0xAFC118", Offset = "0xAFC118", VA = "0xAFC118", Slot = "21")]
	public override void UpdateLookAtPosition()
	{
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0xAFC1E0", Offset = "0xAFC1E0", VA = "0xAFC1E0")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0xAFC4DC", Offset = "0xAFC4DC", VA = "0xAFC4DC")]
	public CharacterEmitter()
	{
	}
}
