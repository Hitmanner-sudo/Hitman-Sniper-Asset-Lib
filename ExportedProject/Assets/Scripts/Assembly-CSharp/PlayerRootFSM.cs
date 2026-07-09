using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000484")]
public class PlayerRootFSM : PlayerFSM
{
	[Token(Token = "0x2000485")]
	public class Reload : BaseState
	{
		[Token(Token = "0x40018AE")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 initialPositionOffset;

		[Token(Token = "0x40018AF")]
		[FieldOffset(Offset = "0x2C")]
		private Quaternion initialRotationOffset;

		[Token(Token = "0x40018B0")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 positionOffset;

		[Token(Token = "0x40018B1")]
		[FieldOffset(Offset = "0x48")]
		private Quaternion rotationOffset;

		[Token(Token = "0x40018B2")]
		[FieldOffset(Offset = "0x58")]
		private int _timerIdx;

		[Token(Token = "0x40018B3")]
		[FieldOffset(Offset = "0x60")]
		private GameTimer _timer;

		[Token(Token = "0x40018B4")]
		[FieldOffset(Offset = "0x68")]
		private GameTimer _outofScopeTransitionTimer;

		[Token(Token = "0x40018B5")]
		[FieldOffset(Offset = "0x70")]
		private GameTimer _intoScopeTransitionTimer;

		[Token(Token = "0x6001B6C")]
		[Address(RVA = "0x8D4A08", Offset = "0x8D4A08", VA = "0x8D4A08", Slot = "4")]
		public override void Init(FSM parentFSM)
		{
		}

		[Token(Token = "0x6001B6D")]
		[Address(RVA = "0x8D4AAC", Offset = "0x8D4AAC", VA = "0x8D4AAC", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x8D4AF4", Offset = "0x8D4AF4", VA = "0x8D4AF4", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x8D5130", Offset = "0x8D5130", VA = "0x8D5130", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x8D5048", Offset = "0x8D5048", VA = "0x8D5048")]
		private bool FinishedReload()
		{
			return default(bool);
		}

		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x8D5134", Offset = "0x8D5134", VA = "0x8D5134")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x617CD4", Offset = "0x617CD4")]
		protected static bool TestSniping(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x8D5280", Offset = "0x8D5280", VA = "0x8D5280")]
		public Reload()
		{
		}
	}

	[Token(Token = "0x2000486")]
	public class Sniping : BaseState
	{
		[Token(Token = "0x2000487")]
		public class AimInfo : EventArgs
		{
			[Token(Token = "0x40018B9")]
			[FieldOffset(Offset = "0x10")]
			public PlayerController Player;

			[Token(Token = "0x40018BA")]
			[FieldOffset(Offset = "0x18")]
			public Type State;

			[Token(Token = "0x40018BB")]
			[FieldOffset(Offset = "0x20")]
			public RaycastHit[] Hits;

			[Token(Token = "0x6001B7D")]
			[Address(RVA = "0xA46B94", Offset = "0xA46B94", VA = "0xA46B94")]
			public AimInfo()
			{
			}
		}

		[Token(Token = "0x2000488")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594BD0", Offset = "0x594BD0")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x40018BC")]
			[FieldOffset(Offset = "0x10")]
			public Sniping _003C_003E4__this;

			[Token(Token = "0x40018BD")]
			[FieldOffset(Offset = "0x18")]
			public Transform aimingCameraTransform;

			[Token(Token = "0x6001B7E")]
			[Address(RVA = "0xA46A44", Offset = "0xA46A44", VA = "0xA46A44")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6001B7F")]
			[Address(RVA = "0xA46A4C", Offset = "0xA46A4C", VA = "0xA46A4C")]
			internal AimInfo _003CUpdateAim_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x40018B6")]
		[FieldOffset(Offset = "0x0")]
		public static int DISTANCE_LAYER;

		[Token(Token = "0x40018B8")]
		[FieldOffset(Offset = "0x20")]
		private SnipingFSM _fsm;

		[Token(Token = "0x1400006A")]
		public static event EventHandler<AimInfo> OnPlayerAim
		{
			[Token(Token = "0x6001B73")]
			[Address(RVA = "0x8D5288", Offset = "0x8D5288", VA = "0x8D5288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617D38", Offset = "0x617D38")]
			add
			{
			}
			[Token(Token = "0x6001B74")]
			[Address(RVA = "0x8D5380", Offset = "0x8D5380", VA = "0x8D5380")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617D48", Offset = "0x617D48")]
			remove
			{
			}
		}

		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x8D5478", Offset = "0x8D5478", VA = "0x8D5478", Slot = "4")]
		public override void Init(FSM parentFSM)
		{
		}

		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x8D5550", Offset = "0x8D5550", VA = "0x8D5550", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x8D557C", Offset = "0x8D557C", VA = "0x8D557C", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x8D55B0", Offset = "0x8D55B0", VA = "0x8D55B0")]
		private void UpdateAim()
		{
		}

		[Token(Token = "0x6001B79")]
		[Address(RVA = "0x8D56F4", Offset = "0x8D56F4", VA = "0x8D56F4", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6001B7A")]
		[Address(RVA = "0x8D5710", Offset = "0x8D5710", VA = "0x8D5710")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x617D58", Offset = "0x617D58")]
		protected static bool TestReload(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B7B")]
		[Address(RVA = "0x8D57E0", Offset = "0x8D57E0", VA = "0x8D57E0")]
		public Sniping()
		{
		}
	}

	[Token(Token = "0x2000489")]
	public class WaitingForReady : BaseState
	{
		[Token(Token = "0x6001B80")]
		[Address(RVA = "0x8D583C", Offset = "0x8D583C", VA = "0x8D583C", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x8D5960", Offset = "0x8D5960", VA = "0x8D5960")]
		private void OnWeaponAttachedCompleted(object sender, EventArgs args)
		{
		}

		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x8D59EC", Offset = "0x8D59EC", VA = "0x8D59EC", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x8D5AC8", Offset = "0x8D5AC8", VA = "0x8D5AC8", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x8D5CA8", Offset = "0x8D5CA8", VA = "0x8D5CA8")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x617DBC", Offset = "0x617DBC")]
		protected static bool TestReady(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x8D5E70", Offset = "0x8D5E70", VA = "0x8D5E70")]
		public WaitingForReady()
		{
		}
	}

	[Token(Token = "0x6001B6B")]
	[Address(RVA = "0xAB6890", Offset = "0xAB6890", VA = "0xAB6890")]
	public PlayerRootFSM(Type initialState, PlayerController player)
	{
	}
}
