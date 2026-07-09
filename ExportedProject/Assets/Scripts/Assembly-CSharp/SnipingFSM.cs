using System;
using Il2CppDummyDll;

[Token(Token = "0x2000491")]
public class SnipingFSM : PlayerFSM
{
	[Token(Token = "0x2000492")]
	public class InScope : BaseState
	{
		[Token(Token = "0x40018C3")]
		[FieldOffset(Offset = "0x0")]
		private static int FOV_PARAM_ID;

		[Token(Token = "0x40018C4")]
		[FieldOffset(Offset = "0x20")]
		private PlayerScopeFSM _fsm;

		[Token(Token = "0x40018C5")]
		[FieldOffset(Offset = "0x28")]
		private float _lastFoundTargetTime;

		[Token(Token = "0x40018C6")]
		[FieldOffset(Offset = "0x2C")]
		private float _checkDistance;

		[Token(Token = "0x6001BAA")]
		[Address(RVA = "0xA4AB1C", Offset = "0xA4AB1C", VA = "0xA4AB1C")]
		private void ExecuteSystem(PlayerSystem aPlayerSystem)
		{
		}

		[Token(Token = "0x6001BAB")]
		[Address(RVA = "0xA4ABC0", Offset = "0xA4ABC0", VA = "0xA4ABC0")]
		private void ApplySystem(PlayerSystem aPlayerSystem)
		{
		}

		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0xA4AC64", Offset = "0xA4AC64", VA = "0xA4AC64", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0xA4AFE4", Offset = "0xA4AFE4", VA = "0xA4AFE4", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001BAE")]
		[Address(RVA = "0xA4B284", Offset = "0xA4B284", VA = "0xA4B284")]
		private void OnPlayerAim(object sender, PlayerRootFSM.Sniping.AimInfo e)
		{
		}

		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0xA4B5B4", Offset = "0xA4B5B4", VA = "0xA4B5B4", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0xA4B8E8", Offset = "0xA4B8E8", VA = "0xA4B8E8")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x618208", Offset = "0x618208")]
		protected static bool TestOutOfScope(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0xA4B988", Offset = "0xA4B988", VA = "0xA4B988")]
		public InScope()
		{
		}
	}

	[Token(Token = "0x2000493")]
	public class InScopeTransition : BaseState
	{
		[Token(Token = "0x6001BB3")]
		[Address(RVA = "0xA4B9FC", Offset = "0xA4B9FC", VA = "0xA4B9FC", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0xA4BA00", Offset = "0xA4BA00", VA = "0xA4BA00", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001BB5")]
		[Address(RVA = "0xA4BC40", Offset = "0xA4BC40", VA = "0xA4BC40", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6001BB6")]
		[Address(RVA = "0xA4BD64", Offset = "0xA4BD64", VA = "0xA4BD64")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x61826C", Offset = "0x61826C")]
		protected static bool TestInScope(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001BB7")]
		[Address(RVA = "0xA4BDF8", Offset = "0xA4BDF8", VA = "0xA4BDF8")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6182D0", Offset = "0x6182D0")]
		protected static bool TestOutOfScope(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001BB8")]
		[Address(RVA = "0xA4BE8C", Offset = "0xA4BE8C", VA = "0xA4BE8C")]
		public InScopeTransition()
		{
		}
	}

	[Token(Token = "0x2000494")]
	public class OutOfScope : BaseState
	{
		[Token(Token = "0x40018C7")]
		[FieldOffset(Offset = "0x20")]
		private bool _fpsNeedToSample;

		[Token(Token = "0x40018C8")]
		[FieldOffset(Offset = "0x24")]
		private float _fpsElapsedTime;

		[Token(Token = "0x40018C9")]
		[FieldOffset(Offset = "0x28")]
		private int _fpsElapsedFrames;

		[Token(Token = "0x40018CA")]
		[FieldOffset(Offset = "0x2C")]
		private float _fpsCalculationDelay;

		[Token(Token = "0x40018CB")]
		private const int FPS_CALCULATION_FROM_MISSION = 2;

		[Token(Token = "0x40018CC")]
		private const float FPS_TOTAL_CALCULATION_TIME = 3f;

		[Token(Token = "0x40018CD")]
		private const float FPS_FRAME_THRESHOLD = 12f;

		[Token(Token = "0x40018CE")]
		private const float FPS_CALCULATION_DELAY = 3f;

		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0xA4BE94", Offset = "0xA4BE94", VA = "0xA4BE94", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0xA4C050", Offset = "0xA4C050", VA = "0xA4C050", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001BBB")]
		[Address(RVA = "0xA4C1E4", Offset = "0xA4C1E4", VA = "0xA4C1E4")]
		private void CheckEveryplayFPS()
		{
		}

		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0xA4C6F4", Offset = "0xA4C6F4", VA = "0xA4C6F4", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0xA4C774", Offset = "0xA4C774", VA = "0xA4C774")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x618334", Offset = "0x618334")]
		protected static bool TestInScope(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0xA4C814", Offset = "0xA4C814", VA = "0xA4C814")]
		public OutOfScope()
		{
		}
	}

	[Token(Token = "0x2000495")]
	public class OutOfScopeTransition : BaseState
	{
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0xA4C81C", Offset = "0xA4C81C", VA = "0xA4C81C", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001BC0")]
		[Address(RVA = "0xA4C820", Offset = "0xA4C820", VA = "0xA4C820", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001BC1")]
		[Address(RVA = "0xA4CA60", Offset = "0xA4CA60", VA = "0xA4CA60", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6001BC2")]
		[Address(RVA = "0xA4CA64", Offset = "0xA4CA64", VA = "0xA4CA64")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x618398", Offset = "0x618398")]
		protected static bool TestOutOfScope(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001BC3")]
		[Address(RVA = "0xA4CAF8", Offset = "0xA4CAF8", VA = "0xA4CAF8")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6183FC", Offset = "0x6183FC")]
		protected static bool TestInScope(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001BC4")]
		[Address(RVA = "0xA4CB8C", Offset = "0xA4CB8C", VA = "0xA4CB8C")]
		public OutOfScopeTransition()
		{
		}
	}

	[Token(Token = "0x6001BA9")]
	[Address(RVA = "0xA65380", Offset = "0xA65380", VA = "0xA65380")]
	public SnipingFSM(Type initialState, PlayerController player)
	{
	}
}
