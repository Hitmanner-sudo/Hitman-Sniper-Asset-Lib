using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000176")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x592780", Offset = "0x592780")]
public class ThirdPersonCharacter : Character
{
	[Token(Token = "0x2000177")]
	private class CharacterFSM : FSM
	{
		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ThirdPersonCharacter Character;

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xA59584", Offset = "0xA59584", VA = "0xA59584")]
		public CharacterFSM(ThirdPersonCharacter character, Type initialState)
		{
		}
	}

	[Token(Token = "0x2000178")]
	private enum StairsIndex
	{
		[Token(Token = "0x4000848")]
		Flat = 0,
		[Token(Token = "0x4000849")]
		StairsUp = 1,
		[Token(Token = "0x400084A")]
		StairsDown = 2
	}

	[Token(Token = "0x2000179")]
	private abstract class CharacterState : FSMState
	{
		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ThirdPersonCharacter _character;

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xA59604", Offset = "0xA59604", VA = "0xA59604", Slot = "4")]
		public override void Init(FSM parentFSM)
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xA5957C", Offset = "0xA5957C", VA = "0xA5957C")]
		protected CharacterState()
		{
		}
	}

	[Token(Token = "0x200017A")]
	private abstract class AliveState : CharacterState
	{
		[Token(Token = "0x400084C")]
		private const string SET_NEXT_RANDOM_ANIM = "SetNextRandomAnim";

		[Token(Token = "0x400084D")]
		private const string ATTACK_ANIM_DONE = "AttackAnimDone";

		[Token(Token = "0x400084E")]
		private const string SPAWNING_ANIM_DONE = "SpawningAnimDone";

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xA58C44", Offset = "0xA58C44", VA = "0xA58C44", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xA58D50", Offset = "0xA58D50", VA = "0xA58D50", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xA58EFC", Offset = "0xA58EFC", VA = "0xA58EFC", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xA5905C", Offset = "0xA5905C", VA = "0xA5905C")]
		private void OnAnimEvent(GameObject sender, AnimationEvent ev)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xA59070", Offset = "0xA59070", VA = "0xA59070", Slot = "10")]
		protected virtual void DoOnAnimEvent(AnimationEvent ev)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xA59408", Offset = "0xA59408", VA = "0xA59408")]
		private void GoToDeadState(object sender, Health.TakeDamageEventArgs args)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xA59574", Offset = "0xA59574", VA = "0xA59574")]
		protected AliveState()
		{
		}
	}

	[Token(Token = "0x200017B")]
	private class Interrupted : AliveState
	{
		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameTimer _interruptTimer;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _interruptTime;

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xA34138", Offset = "0xA34138", VA = "0xA34138", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xA34180", Offset = "0xA34180", VA = "0xA34180", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xA34188", Offset = "0xA34188", VA = "0xA34188", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xA34190", Offset = "0xA34190", VA = "0xA34190")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6130F0", Offset = "0x6130F0")]
		protected static bool TestTransitionToIdle(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0xA3421C", Offset = "0xA3421C", VA = "0xA3421C")]
		public Interrupted()
		{
		}
	}

	[Token(Token = "0x200017C")]
	private abstract class Healthy : AliveState
	{
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xA5A5D8", Offset = "0xA5A5D8", VA = "0xA5A5D8", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0xA5A5DC", Offset = "0xA5A5DC", VA = "0xA5A5DC")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613154", Offset = "0x613154")]
		protected static bool TestTransitionToHurting(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xA5A668", Offset = "0xA5A668", VA = "0xA5A668")]
		protected Healthy()
		{
		}
	}

	[Token(Token = "0x200017D")]
	private class Screaming : AliveState
	{
		[Token(Token = "0x4000851")]
		private const string START_SCREAMING = "StartScreaming";

		[Token(Token = "0x4000852")]
		private const string STOP_SCREAMING = "StopScreaming";

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _screamingDone;

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xA35E40", Offset = "0xA35E40", VA = "0xA35E40", Slot = "4")]
		public override void Init(FSM parentFSM)
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xA35E68", Offset = "0xA35E68", VA = "0xA35E68", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xA35EFC", Offset = "0xA35EFC", VA = "0xA35EFC", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xA35F8C", Offset = "0xA35F8C", VA = "0xA35F8C", Slot = "10")]
		protected override void DoOnAnimEvent(AnimationEvent ev)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xA3623C", Offset = "0xA3623C", VA = "0xA3623C")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6131B8", Offset = "0x6131B8")]
		protected static bool TestTransitionToIdle(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xA362C0", Offset = "0xA362C0", VA = "0xA362C0")]
		public Screaming()
		{
		}
	}

	[Token(Token = "0x200017E")]
	private class Idle : Healthy
	{
		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationConfig.IdleType IdleType;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameTimer _idleInTimer;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameTimer _breakerTimer;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _needsIdleOut;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AnimationConfig.IdleOptions _idleOptions;

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xA5AE64", Offset = "0xA5AE64", VA = "0xA5AE64")]
		public bool IsPlaying(AnimationConfig.IdleType idleType, bool ignoreTransitions)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xA5AEA4", Offset = "0xA5AEA4", VA = "0xA5AEA4", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xA5B130", Offset = "0xA5B130", VA = "0xA5B130", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xA5B380", Offset = "0xA5B380", VA = "0xA5B380", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xA5B50C", Offset = "0xA5B50C", VA = "0xA5B50C")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x61321C", Offset = "0x61321C")]
		protected static bool TestTransitionToInterrupted(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xA5B598", Offset = "0xA5B598", VA = "0xA5B598")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613280", Offset = "0x613280")]
		protected static bool TestTransitionToIdleOut(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xA5B6A8", Offset = "0xA5B6A8", VA = "0xA5B6A8")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6132E4", Offset = "0x6132E4")]
		protected static bool TestTransitionToSelf(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xA5B790", Offset = "0xA5B790", VA = "0xA5B790")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613348", Offset = "0x613348")]
		protected static bool TestTransitionToMoving(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xA5B8B4", Offset = "0xA5B8B4", VA = "0xA5B8B4")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6133AC", Offset = "0x6133AC")]
		protected static bool TestTransitionToTurn(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xA5B9D8", Offset = "0xA5B9D8", VA = "0xA5B9D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xA5BA74", Offset = "0xA5BA74", VA = "0xA5BA74")]
		public Idle()
		{
		}
	}

	[Token(Token = "0x200017F")]
	private class IdleOut : Healthy
	{
		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameTimer _outTimer;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int stateNameHash;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int defaultStateHash;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AnimationConfig.IdleType _idleType;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AnimationConfig.IdleOptions _idleOptions;

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xA3353C", Offset = "0xA3353C", VA = "0xA3353C", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xA33708", Offset = "0xA33708", VA = "0xA33708", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xA33884", Offset = "0xA33884", VA = "0xA33884", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xA33A50", Offset = "0xA33A50", VA = "0xA33A50")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613410", Offset = "0x613410")]
		protected static bool TestTransitionToMoving(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xA33BAC", Offset = "0xA33BAC", VA = "0xA33BAC")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613474", Offset = "0x613474")]
		protected static bool TransitionToTurning(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0xA33D08", Offset = "0xA33D08", VA = "0xA33D08")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6134D8", Offset = "0x6134D8")]
		protected static bool TransitionToIdle(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0xA33D94", Offset = "0xA33D94", VA = "0xA33D94", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0xA33FD8", Offset = "0xA33FD8", VA = "0xA33FD8")]
		public IdleOut()
		{
		}
	}

	[Token(Token = "0x2000180")]
	private class Turning : Healthy
	{
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xA36710", Offset = "0xA36710", VA = "0xA36710", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xA368C8", Offset = "0xA368C8", VA = "0xA368C8", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xA36AB4", Offset = "0xA36AB4", VA = "0xA36AB4", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xA36C44", Offset = "0xA36C44", VA = "0xA36C44")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x61353C", Offset = "0x61353C")]
		protected static bool TestTransitionToIdle(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0xA36DEC", Offset = "0xA36DEC", VA = "0xA36DEC")]
		public Turning()
		{
		}
	}

	[Token(Token = "0x2000181")]
	private class MoveAnticipation : Healthy
	{
		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _done;

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0xA34288", Offset = "0xA34288", VA = "0xA34288", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xA343C4", Offset = "0xA343C4", VA = "0xA343C4", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xA343CC", Offset = "0xA343CC", VA = "0xA343CC", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xA345E0", Offset = "0xA345E0", VA = "0xA345E0")]
		private void OnAnimEvent(GameObject sender, AnimationEvent ev)
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0xA34620", Offset = "0xA34620", VA = "0xA34620")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6135A0", Offset = "0x6135A0")]
		protected static bool TestTransitionToIdle(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xA346B8", Offset = "0xA346B8", VA = "0xA346B8")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613604", Offset = "0x613604")]
		protected static bool TestTransitionToMoving(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xA3473C", Offset = "0xA3473C", VA = "0xA3473C")]
		public MoveAnticipation()
		{
		}
	}

	[Token(Token = "0x2000182")]
	private class Moving : Healthy
	{
		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameTimer _breakerTimer;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _stopMoving;

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xA352FC", Offset = "0xA352FC", VA = "0xA352FC", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xA35578", Offset = "0xA35578", VA = "0xA35578", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xA35930", Offset = "0xA35930", VA = "0xA35930", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xA354AC", Offset = "0xA354AC", VA = "0xA354AC")]
		private void StartBreakerTimer()
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xA359D0", Offset = "0xA359D0", VA = "0xA359D0")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613668", Offset = "0x613668")]
		protected static bool TestTransitionToStop(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xA35A54", Offset = "0xA35A54", VA = "0xA35A54")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6136CC", Offset = "0x6136CC")]
		protected static bool TestTransitionToIdle(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xA35B4C", Offset = "0xA35B4C", VA = "0xA35B4C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xA35C18", Offset = "0xA35C18", VA = "0xA35C18")]
		public Moving()
		{
		}
	}

	[Token(Token = "0x2000183")]
	private class MoveStop : Healthy
	{
		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _nearingDestination;

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xA34744", Offset = "0xA34744", VA = "0xA34744", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xA34888", Offset = "0xA34888", VA = "0xA34888", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xA34CD8", Offset = "0xA34CD8", VA = "0xA34CD8", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xA34E7C", Offset = "0xA34E7C", VA = "0xA34E7C")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613730", Offset = "0x613730")]
		protected static bool TestTransitionToMoving(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xA3509C", Offset = "0xA3509C", VA = "0xA3509C")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613794", Offset = "0x613794")]
		protected static bool TestTurning(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xA351E8", Offset = "0xA351E8", VA = "0xA351E8")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6137F8", Offset = "0x6137F8")]
		protected static bool TestTransitionToIdle(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xA352F4", Offset = "0xA352F4", VA = "0xA352F4")]
		public MoveStop()
		{
		}
	}

	[Token(Token = "0x2000184")]
	private class Hurting : AliveState
	{
		[Token(Token = "0x2000185")]
		private class InPain : CharacterState
		{
			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GameTimer _breakerTimer;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private AnimationConfig.IdleOptions _idleOptions;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool _idleOutSet;

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0xA471CC", Offset = "0xA471CC", VA = "0xA471CC", Slot = "5")]
			public override void Enter()
			{
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0xA47390", Offset = "0xA47390", VA = "0xA47390", Slot = "6")]
			public override void Execute()
			{
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0xA4744C", Offset = "0xA4744C", VA = "0xA4744C", Slot = "7")]
			public override void Exit()
			{
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0xA475DC", Offset = "0xA475DC", VA = "0xA475DC")]
			[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613924", Offset = "0x613924")]
			protected static bool TestTransitionToCommunicateInPain(FSMState instance)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0xA476E8", Offset = "0xA476E8", VA = "0xA476E8")]
			public InPain()
			{
			}
		}

		[Token(Token = "0x2000186")]
		private class CommunicateInPain : CharacterState
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0xA470A0", Offset = "0xA470A0", VA = "0xA470A0", Slot = "5")]
			public override void Enter()
			{
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0xA47128", Offset = "0xA47128", VA = "0xA47128", Slot = "6")]
			public override void Execute()
			{
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0xA4712C", Offset = "0xA4712C", VA = "0xA4712C", Slot = "7")]
			public override void Exit()
			{
			}

			[Token(Token = "0x6000A84")]
			[Address(RVA = "0xA47130", Offset = "0xA47130", VA = "0xA47130")]
			[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613988", Offset = "0x613988")]
			protected static bool TestTransitionToInPain(FSMState instance)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0xA471C4", Offset = "0xA471C4", VA = "0xA471C4")]
			public CommunicateInPain()
			{
			}
		}

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CharacterFSM _internalFSM;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameTimer _hurtingTimer;

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xA5A670", Offset = "0xA5A670", VA = "0xA5A670")]
		public bool IsCommunicateInPain()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xA5A708", Offset = "0xA5A708", VA = "0xA5A708", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xA5A940", Offset = "0xA5A940", VA = "0xA5A940", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0xA5A970", Offset = "0xA5A970", VA = "0xA5A970", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0xA5AB18", Offset = "0xA5AB18", VA = "0xA5AB18")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x61385C", Offset = "0x61385C")]
		protected static bool TestTransitionToStandUp(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0xA5AC4C", Offset = "0xA5AC4C", VA = "0xA5AC4C")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6138C0", Offset = "0x6138C0")]
		protected static bool TestTransitionToRecover(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0xA5AD80", Offset = "0xA5AD80", VA = "0xA5AD80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0xA5AE00", Offset = "0xA5AE00", VA = "0xA5AE00")]
		public Hurting()
		{
		}
	}

	[Token(Token = "0x2000187")]
	private class Recover : Healthy
	{
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0xA35C7C", Offset = "0xA35C7C", VA = "0xA35C7C", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0xA35C84", Offset = "0xA35C84", VA = "0xA35C84", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0xA35E28", Offset = "0xA35E28", VA = "0xA35E28")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6139EC", Offset = "0x6139EC")]
		protected static bool TestTransitionToIdle(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0xA35E30", Offset = "0xA35E30", VA = "0xA35E30")]
		public Recover()
		{
		}
	}

	[Token(Token = "0x2000188")]
	private class StandUp : Healthy
	{
		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameTimer _standupTimer;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameTimer _stateChange;

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0xA362C8", Offset = "0xA362C8", VA = "0xA362C8", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0xA36404", Offset = "0xA36404", VA = "0xA36404", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0xA3645C", Offset = "0xA3645C", VA = "0xA3645C", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0xA36600", Offset = "0xA36600", VA = "0xA36600")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x613A50", Offset = "0x613A50")]
		protected static bool TestTransitionToIdle(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0xA3668C", Offset = "0xA3668C", VA = "0xA3668C")]
		public StandUp()
		{
		}
	}

	[Token(Token = "0x2000189")]
	private class Dead : CharacterState
	{
		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector2 _repositionFactorPrePush;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isHeadShot;

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0xA59694", Offset = "0xA59694", VA = "0xA59694", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0xA598B0", Offset = "0xA598B0", VA = "0xA598B0")]
		private void OnPreTakeDamage(object sender, Health.TakeDamageEventArgs args)
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0xA59A38", Offset = "0xA59A38", VA = "0xA59A38", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xA59A3C", Offset = "0xA59A3C", VA = "0xA59A3C", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0xA59B40", Offset = "0xA59B40", VA = "0xA59B40")]
		public Dead()
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0xA59B7C", Offset = "0xA59B7C", VA = "0xA59B7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613AB4", Offset = "0x613AB4")]
		private bool _003CEnter_003Eb__2_0(AnimationConfig.DeathAnimation d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200018A")]
	private class DeathAnimation : CharacterState
	{
		[Token(Token = "0x200018B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5927E0", Offset = "0x5927E0")]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Damage.Types lastType;

			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0xA47034", Offset = "0xA47034", VA = "0xA47034")]
			public _003C_003Ec__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0xA4703C", Offset = "0xA4703C", VA = "0xA4703C")]
			internal bool _003CEnter_003Eb__0(AnimationConfig.DeathAnimation d)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200018C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5927F0", Offset = "0x5927F0")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Health.TakeDamageEventArgs args;

			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0xA47060", Offset = "0xA47060", VA = "0xA47060")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0xA47068", Offset = "0xA47068", VA = "0xA47068")]
			internal bool _003CCheckWhetherToGoToDeadState_003Eb__0(Damage d)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200018D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592800", Offset = "0x592800")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Damage, float> _003C_003E9__5_1;

			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0xA47014", Offset = "0xA47014", VA = "0xA47014")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0xA4701C", Offset = "0xA4701C", VA = "0xA4701C")]
			internal float _003CCheckWhetherToGoToDeadState_003Eb__5_1(Damage d)
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0xA59BC8", Offset = "0xA59BC8", VA = "0xA59BC8", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xA59FB4", Offset = "0xA59FB4", VA = "0xA59FB4", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xA59F70", Offset = "0xA59F70", VA = "0xA59F70")]
		private Vector3 GetTorsoPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xA5A0D8", Offset = "0xA5A0D8", VA = "0xA5A0D8", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0xA5A24C", Offset = "0xA5A24C", VA = "0xA5A24C")]
		private void OnAnimEvent(GameObject sender, AnimationEvent ev)
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0xA5A320", Offset = "0xA5A320", VA = "0xA5A320")]
		private void CheckWhetherToGoToDeadState(object sender, Health.TakeDamageEventArgs args)
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0xA5A5D0", Offset = "0xA5A5D0", VA = "0xA5A5D0")]
		public DeathAnimation()
		{
		}
	}

	[Token(Token = "0x200018E")]
	private class SamplingPrediction
	{
		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Origin;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Displacement;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 Direction;

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0xA35E38", Offset = "0xA35E38", VA = "0xA35E38")]
		public SamplingPrediction()
		{
		}
	}

	[Token(Token = "0x200018F")]
	public class InjuryEvent : EventArgs
	{
		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Character Character;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Damage.BodyPart BodyPart;

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0xA340D4", Offset = "0xA340D4", VA = "0xA340D4")]
		public InjuryEvent()
		{
		}
	}

	[Token(Token = "0x2000190")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592810", Offset = "0x592810")]
	private sealed class _003CCorpseFadeOut_003Ed__197 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Material material;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float duration;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Color _003Ccolor_003E5__2;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _003Cstart_003E5__3;

		[Token(Token = "0x170001A9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0xA57E8C", Offset = "0xA57E8C", VA = "0xA57E8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0xA57ED4", Offset = "0xA57ED4", VA = "0xA57ED4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xA57B28", Offset = "0xA57B28", VA = "0xA57B28")]
		[DebuggerHidden]
		public _003CCorpseFadeOut_003Ed__197(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xA57B54", Offset = "0xA57B54", VA = "0xA57B54", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xA57B58", Offset = "0xA57B58", VA = "0xA57B58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xA57E94", Offset = "0xA57E94", VA = "0xA57E94", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000191")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592820", Offset = "0x592820")]
	private sealed class _003C_003Ec__DisplayClass223_0
	{
		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ThirdPersonCharacter _003C_003E4__this;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xA576CC", Offset = "0xA576CC", VA = "0xA576CC")]
		public _003C_003Ec__DisplayClass223_0()
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xA576D4", Offset = "0xA576D4", VA = "0xA576D4")]
		internal void _003CSetBoolTemp_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000192")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592830", Offset = "0x592830")]
	private sealed class _003C_003Ec__DisplayClass237_0
	{
		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform heartTransform;

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xA577E8", Offset = "0xA577E8", VA = "0xA577E8")]
		public _003C_003Ec__DisplayClass237_0()
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0xA577F0", Offset = "0xA577F0", VA = "0xA577F0")]
		internal bool _003CEnableRagdoll_003Eb__0(Collider x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592840", Offset = "0x592840")]
	private sealed class _003CDisableRigidBodiesDelayed_003Ed__241 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThirdPersonCharacter _003C_003E4__this;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003Cdelay_003E5__2;

		[Token(Token = "0x170001AB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xA581C8", Offset = "0xA581C8", VA = "0xA581C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0xA58210", Offset = "0xA58210", VA = "0xA58210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0xA57EDC", Offset = "0xA57EDC", VA = "0xA57EDC")]
		[DebuggerHidden]
		public _003CDisableRigidBodiesDelayed_003Ed__241(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0xA57F08", Offset = "0xA57F08", VA = "0xA57F08", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xA57F0C", Offset = "0xA57F0C", VA = "0xA57F0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0xA581D0", Offset = "0xA581D0", VA = "0xA581D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000194")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592850", Offset = "0x592850")]
	private sealed class _003CFreezing_003Ed__254 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThirdPersonCharacter _003C_003E4__this;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Damage damage;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Bullet.Hit hit;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AIController _003CaiController_003E5__2;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private FreezeAndKillConfig _003CfreezeAndKillConfig_003E5__3;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material _003CfreezeMaterialClone_003E5__4;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GameTimer _003Ctimer_003E5__5;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameTimer _003Ctimer2_003E5__6;

		[Token(Token = "0x170001AD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0xA58BF4", Offset = "0xA58BF4", VA = "0xA58BF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0xA58C3C", Offset = "0xA58C3C", VA = "0xA58C3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0xA58328", Offset = "0xA58328", VA = "0xA58328")]
		[DebuggerHidden]
		public _003CFreezing_003Ed__254(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xA58354", Offset = "0xA58354", VA = "0xA58354", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xA58358", Offset = "0xA58358", VA = "0xA58358", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0xA58BFC", Offset = "0xA58BFC", VA = "0xA58BFC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000195")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592860", Offset = "0x592860")]
	private sealed class _003CBurning_003Ed__256 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThirdPersonCharacter _003C_003E4__this;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material _003CmaterialClone_003E5__2;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameTimer _003Ctimer_003E5__3;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color _003Ccolor_003E5__4;

		[Token(Token = "0x170001AF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0xA57AD8", Offset = "0xA57AD8", VA = "0xA57AD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xA57B20", Offset = "0xA57B20", VA = "0xA57B20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xA57898", Offset = "0xA57898", VA = "0xA57898")]
		[DebuggerHidden]
		public _003CBurning_003Ed__256(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xA578C4", Offset = "0xA578C4", VA = "0xA578C4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0xA578C8", Offset = "0xA578C8", VA = "0xA578C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0xA57AE0", Offset = "0xA57AE0", VA = "0xA57AE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000196")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592870", Offset = "0x592870")]
	private sealed class _003CDoStopBodyAsDominoKillInOneShoot_003Ed__264 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThirdPersonCharacter _003C_003E4__this;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x170001B1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0xA582D8", Offset = "0xA582D8", VA = "0xA582D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0xA58320", Offset = "0xA58320", VA = "0xA58320", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0xA58218", Offset = "0xA58218", VA = "0xA58218")]
		[DebuggerHidden]
		public _003CDoStopBodyAsDominoKillInOneShoot_003Ed__264(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0xA58244", Offset = "0xA58244", VA = "0xA58244", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0xA58248", Offset = "0xA58248", VA = "0xA58248", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0xA582E0", Offset = "0xA582E0", VA = "0xA582E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40007F0")]
	private const int LOW_QUALITY_UPDATE_FRAMES = 8;

	[Token(Token = "0x40007F1")]
	private const int HIGH_QUALITY_UPDATE_FRAMES = 4;

	[Token(Token = "0x40007F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int LOW_OUT_OF_FRUSTRUM_UPDATE_FRAMES;

	[Token(Token = "0x40007F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int HIGH_OUT_OF_FRUSTRUM_UPDATE_FRAMES;

	[Token(Token = "0x40007F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _isUpdatingOutOfScreenAnimation;

	[NonSerialized]
	[Token(Token = "0x40007F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float LastUpdateTime;

	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1EEC", Offset = "0x5B1EEC")]
	private AnimationConfig.IdleType _003CIdleType_003Ek__BackingField;

	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1EFC", Offset = "0x5B1EFC")]
	private bool _003CAttackStartDoDamage_003Ek__BackingField;

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1F0C", Offset = "0x5B1F0C")]
	private bool _003CAttackDoneDoDamage_003Ek__BackingField;

	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1F1C", Offset = "0x5B1F1C")]
	private string _003CAttackDoneOrigin_003Ek__BackingField;

	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public float AttackDoneValue;

	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1F3C", Offset = "0x5B1F3C")]
	private bool _003CAdjustPosition_003Ek__BackingField;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private PlayMakerFSM _patientPlayMakerFSM;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1F4C", Offset = "0x5B1F4C")]
	private FSM _003CFSM_003Ek__BackingField;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1F5C", Offset = "0x5B1F5C")]
	private bool _003CIsHurting_003Ek__BackingField;

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private StairsIndex _stairsIndex;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1F6C", Offset = "0x5B1F6C")]
	private bool _003CDisableIdleBreakers_003Ek__BackingField;

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector3 _lastTorsoMovement;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Vector3 _lastTorsoPosition;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Animator _animator;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private AnimationEventProxy AnimEvents;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private CharacterLODController _lodController;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private CharacterShadowController _shadowController;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<SkinnedMeshRenderer> _skinnedMeshRenderers;

	[NonSerialized]
	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public CharacterEmitter Emitter;

	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1F7C", Offset = "0x5B1F7C")]
	private Transform _003CCharacter_003Ek__BackingField;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Transform _headHigh;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Vector3 _headColliderCenter;

	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private Vector3 _torsoColliderCenter;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1F8C", Offset = "0x5B1F8C")]
	private Transform _003CTorso_003Ek__BackingField;

	[Token(Token = "0x400080F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1F9C", Offset = "0x5B1F9C")]
	private Transform _003COldTorso_003Ek__BackingField;

	[Token(Token = "0x4000810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public bool TriggerHurtingState;

	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
	public bool NoReactionToAlert;

	[Token(Token = "0x4000812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
	public bool AnimatorSupportsFemales;

	[Token(Token = "0x4000813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x153")]
	public bool AdjustSpeedWhenWounded;

	[Token(Token = "0x4000814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public bool WalkSlowAllowedWhenAlerted;

	[Token(Token = "0x4000815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public BoneInfo[] BonesInfo;

	[Token(Token = "0x4000816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private bool _cachedIsLowQuality;

	[Token(Token = "0x4000817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private GameTimer _timeSinceLastDesiredVel;

	[Token(Token = "0x4000818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private float _maxWaitTime;

	[NonSerialized]
	[Token(Token = "0x4000819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private Vector3 _desiredVelocity;

	[Token(Token = "0x400081A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private bool IsFreezing;

	[Token(Token = "0x400081B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
	private bool IsBurning;

	[Token(Token = "0x400081C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private Vector3 _destination;

	[Token(Token = "0x400081D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool _stopAtDestination;

	[Token(Token = "0x400081E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private float _remainingNodeDistance;

	[Token(Token = "0x400081F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private bool _needToTurn;

	[Token(Token = "0x4000820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private float MovementHandicap;

	[Token(Token = "0x4000821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public bool IsInBodyBagMode;

	[NonSerialized]
	[Token(Token = "0x4000822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A1")]
	public bool WasInterrupted;

	[NonSerialized]
	[Token(Token = "0x4000823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private Vector3 _desiredOrientation;

	[NonSerialized]
	[Token(Token = "0x4000824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public Quaternion DesiredAim;

	[NonSerialized]
	[Token(Token = "0x4000825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public Vector3 DesiredHeadDirection;

	[Token(Token = "0x4000826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private RangeClassifier _stairsClassifier;

	[Token(Token = "0x4000827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static RangeClassifier SpeedClassifier;

	[NonSerialized]
	[Token(Token = "0x4000828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public int LastSpeedDivision;

	[Token(Token = "0x4000829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public Blackboard Properties;

	[NonSerialized]
	[Token(Token = "0x400082A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public bool IsSpawning;

	[NonSerialized]
	[Token(Token = "0x400082B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E9")]
	public bool RigidbodiesAlwaysEnable;

	[NonSerialized]
	[Token(Token = "0x400082C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public GameObject PossessedBody;

	[NonSerialized]
	[Token(Token = "0x400082D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public bool DominoKillInOneShoot;

	[Token(Token = "0x400082E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
	private int seed;

	[Token(Token = "0x400082F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int seedCount;

	[NonSerialized]
	[Token(Token = "0x4000830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private HierarchicalCollision _hierarchicalCollision;

	[NonSerialized]
	[Token(Token = "0x4000831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private AIMemento _reaction;

	[Token(Token = "0x4000832")]
	private const int _nbCharacterStatesToKeep = 5;

	[Token(Token = "0x4000833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private CircularBuffer<CharacterAnimState> _animStates;

	[Token(Token = "0x4000834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private CircularBuffer<CharacterAnimStance> _animStances;

	[Token(Token = "0x4000835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private PlayingSoundContainer _currentSound;

	[Token(Token = "0x4000836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private CharacterAnimState _alertness;

	[Token(Token = "0x4000837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1FAC", Offset = "0x5B1FAC")]
	private bool _003CRagdollUntilNextCollision_003Ek__BackingField;

	[Token(Token = "0x4000838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public string RogueFullName;

	[Token(Token = "0x4000839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private int _resetReactFrame;

	[Token(Token = "0x400083A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	private bool _resetReact;

	[Token(Token = "0x400083B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private SamplingPrediction _lastSample;

	[Token(Token = "0x400083C")]
	private const float SamplingPredictionDistance = 0.6f;

	[Token(Token = "0x400083D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private List<Character> _arresters;

	[Token(Token = "0x400083E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private bool _rigidBodiesEnabled;

	[Token(Token = "0x400083F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	private float _disableRigidBodyTime;

	[Token(Token = "0x4000841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	[SerializeField]
	private ThirdPersonCharacter _bodyBagCharacterReferencePrefab;

	[Token(Token = "0x4000843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private bool _isPossessed;

	[Token(Token = "0x4000844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private Coroutine _doStopBodyAsDominoKillInOneShoot;

	[Token(Token = "0x4000845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private AccumulatedForce _accumulatedForce;

	[Token(Token = "0x17000189")]
	private bool IsUpdatingOutOfScreenAnimation
	{
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xAC4AC8", Offset = "0xAC4AC8", VA = "0xAC4AC8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xAC4AD0", Offset = "0xAC4AD0", VA = "0xAC4AD0")]
		set
		{
		}
	}

	[Token(Token = "0x1700018A")]
	public AnimationConfig.IdleType IdleType
	{
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xAC4E88", Offset = "0xAC4E88", VA = "0xAC4E88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612D50", Offset = "0x612D50")]
		get
		{
			return default(AnimationConfig.IdleType);
		}
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xAC4E90", Offset = "0xAC4E90", VA = "0xAC4E90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612D60", Offset = "0x612D60")]
		set
		{
		}
	}

	[Token(Token = "0x1700018B")]
	[HideInInspector]
	public bool AttackStartDoDamage
	{
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xAC4E98", Offset = "0xAC4E98", VA = "0xAC4E98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612D70", Offset = "0x612D70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xAC4EA0", Offset = "0xAC4EA0", VA = "0xAC4EA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612D80", Offset = "0x612D80")]
		set
		{
		}
	}

	[Token(Token = "0x1700018C")]
	[HideInInspector]
	public bool AttackDoneDoDamage
	{
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xAC4EAC", Offset = "0xAC4EAC", VA = "0xAC4EAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612D90", Offset = "0x612D90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xAC4EB4", Offset = "0xAC4EB4", VA = "0xAC4EB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612DA0", Offset = "0x612DA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700018D")]
	[HideInInspector]
	public string AttackDoneOrigin
	{
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xAC4EC0", Offset = "0xAC4EC0", VA = "0xAC4EC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612DB0", Offset = "0x612DB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xAC4EC8", Offset = "0xAC4EC8", VA = "0xAC4EC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612DC0", Offset = "0x612DC0")]
		set
		{
		}
	}

	[Token(Token = "0x1700018E")]
	[HideInInspector]
	public bool AdjustPosition
	{
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xAC4ED0", Offset = "0xAC4ED0", VA = "0xAC4ED0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612DD0", Offset = "0x612DD0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xAC4ED8", Offset = "0xAC4ED8", VA = "0xAC4ED8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612DE0", Offset = "0x612DE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700018F")]
	public FSM FSM
	{
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xAC4EE4", Offset = "0xAC4EE4", VA = "0xAC4EE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612DF0", Offset = "0x612DF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xAC4EEC", Offset = "0xAC4EEC", VA = "0xAC4EEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612E00", Offset = "0x612E00")]
		private set
		{
		}
	}

	[Token(Token = "0x17000190")]
	public bool IsHurting
	{
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xAC59FC", Offset = "0xAC59FC", VA = "0xAC59FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612E10", Offset = "0x612E10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xAC5A04", Offset = "0xAC5A04", VA = "0xAC5A04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612E20", Offset = "0x612E20")]
		private set
		{
		}
	}

	[Token(Token = "0x17000191")]
	public bool DisableIdleBreakers
	{
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xAC60E8", Offset = "0xAC60E8", VA = "0xAC60E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612E30", Offset = "0x612E30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xAC60F0", Offset = "0xAC60F0", VA = "0xAC60F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612E40", Offset = "0x612E40")]
		set
		{
		}
	}

	[Token(Token = "0x17000192")]
	public Animator CurrentAnimator
	{
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xAC6118", Offset = "0xAC6118", VA = "0xAC6118")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xAC6120", Offset = "0xAC6120", VA = "0xAC6120")]
		set
		{
		}
	}

	[Token(Token = "0x17000193")]
	public CharacterLODController LodController
	{
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xAC62C0", Offset = "0xAC62C0", VA = "0xAC62C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000194")]
	public CharacterShadowController ShadowController
	{
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xAC62C8", Offset = "0xAC62C8", VA = "0xAC62C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000195")]
	public Transform Character
	{
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xAC62D0", Offset = "0xAC62D0", VA = "0xAC62D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612E50", Offset = "0x612E50")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xAC62D8", Offset = "0xAC62D8", VA = "0xAC62D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612E60", Offset = "0x612E60")]
		private set
		{
		}
	}

	[Token(Token = "0x17000196")]
	public Transform Head
	{
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xAC62E0", Offset = "0xAC62E0", VA = "0xAC62E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000197")]
	public Vector3 HeadColliderCenter
	{
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xAC62E8", Offset = "0xAC62E8", VA = "0xAC62E8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000198")]
	public Transform Torso
	{
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xAC62F8", Offset = "0xAC62F8", VA = "0xAC62F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612E70", Offset = "0x612E70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xAC6300", Offset = "0xAC6300", VA = "0xAC6300")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612E80", Offset = "0x612E80")]
		private set
		{
		}
	}

	[Token(Token = "0x17000199")]
	public Transform OldTorso
	{
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xAC6308", Offset = "0xAC6308", VA = "0xAC6308")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612E90", Offset = "0x612E90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xAC6310", Offset = "0xAC6310", VA = "0xAC6310")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612EA0", Offset = "0x612EA0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700019A")]
	public override Vector3 EyePosition
	{
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xAC63A8", Offset = "0xAC63A8", VA = "0xAC63A8", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700019B")]
	public override Vector3 EyeDirection
	{
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xAC63D4", Offset = "0xAC63D4", VA = "0xAC63D4", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700019C")]
	public bool DesiredVelElapsed
	{
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xAC6400", Offset = "0xAC6400", VA = "0xAC6400")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700019D")]
	public Vector3 DesiredVelocity
	{
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xAC6484", Offset = "0xAC6484", VA = "0xAC6484")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xAC6494", Offset = "0xAC6494", VA = "0xAC6494")]
		set
		{
		}
	}

	[Token(Token = "0x1700019E")]
	public bool StopAtDestination
	{
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xAC6508", Offset = "0xAC6508", VA = "0xAC6508")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700019F")]
	public Vector3 DesiredOrientation
	{
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xAC6510", Offset = "0xAC6510", VA = "0xAC6510")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xAC6520", Offset = "0xAC6520", VA = "0xAC6520")]
		set
		{
		}
	}

	[Token(Token = "0x170001A0")]
	public Vector3 DesiredAimDirection
	{
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xAC653C", Offset = "0xAC653C", VA = "0xAC653C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xAC6594", Offset = "0xAC6594", VA = "0xAC6594")]
		set
		{
		}
	}

	[Token(Token = "0x170001A1")]
	public HierarchicalCollision HierarchicalCollision
	{
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xAC65F8", Offset = "0xAC65F8", VA = "0xAC65F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001A2")]
	public CharacterAnimState AnimState
	{
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xAC662C", Offset = "0xAC662C", VA = "0xAC662C")]
		get
		{
			return default(CharacterAnimState);
		}
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xAC6688", Offset = "0xAC6688", VA = "0xAC6688")]
		private set
		{
		}
	}

	[Token(Token = "0x170001A3")]
	public CharacterAnimStance AnimStance
	{
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xAC6950", Offset = "0xAC6950", VA = "0xAC6950")]
		get
		{
			return default(CharacterAnimStance);
		}
	}

	[Token(Token = "0x170001A4")]
	public CharacterAnimStance AnimStanceDelay
	{
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xAC69A4", Offset = "0xAC69A4", VA = "0xAC69A4")]
		get
		{
			return default(CharacterAnimStance);
		}
	}

	[Token(Token = "0x170001A5")]
	public bool RagdollUntilNextCollision
	{
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xAC69F8", Offset = "0xAC69F8", VA = "0xAC69F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612EB0", Offset = "0x612EB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xAC6A00", Offset = "0xAC6A00", VA = "0xAC6A00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612EC0", Offset = "0x612EC0")]
		set
		{
		}
	}

	[Token(Token = "0x170001A6")]
	public bool Arrested
	{
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0xAC86A8", Offset = "0xAC86A8", VA = "0xAC86A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001A7")]
	public Character FirstArrester
	{
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xAC86FC", Offset = "0xAC86FC", VA = "0xAC86FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001A8")]
	public Character LastArrester
	{
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0xAC876C", Offset = "0xAC876C", VA = "0xAC876C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400001D")]
	public event EventHandler<EventArgs> OnInflictDamage
	{
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xAC4B80", Offset = "0xAC4B80", VA = "0xAC4B80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612D30", Offset = "0x612D30")]
		add
		{
		}
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xAC4C20", Offset = "0xAC4C20", VA = "0xAC4C20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612D40", Offset = "0x612D40")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001E")]
	public static event EventHandler<InjuryEvent> InjuryCallback
	{
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xAC8C60", Offset = "0xAC8C60", VA = "0xAC8C60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612F30", Offset = "0x612F30")]
		add
		{
		}
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xAC8D58", Offset = "0xAC8D58", VA = "0xAC8D58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612F40", Offset = "0x612F40")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001F")]
	public event AnimationEventProxy.AnimEventDelegate OnAnimEvent
	{
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xACB498", Offset = "0xACB498", VA = "0xACB498")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612FB0", Offset = "0x612FB0")]
		add
		{
		}
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xACB53C", Offset = "0xACB53C", VA = "0xACB53C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x612FC0", Offset = "0x612FC0")]
		remove
		{
		}
	}

	[Token(Token = "0x60009AD")]
	[Address(RVA = "0xAC4CC0", Offset = "0xAC4CC0", VA = "0xAC4CC0")]
	private bool IsOutOfScope()
	{
		return default(bool);
	}

	[Token(Token = "0x60009AE")]
	[Address(RVA = "0xAC4D64", Offset = "0xAC4D64", VA = "0xAC4D64")]
	private bool IsOutOfFrustrum()
	{
		return default(bool);
	}

	[Token(Token = "0x60009AF")]
	[Address(RVA = "0xAC4D98", Offset = "0xAC4D98", VA = "0xAC4D98")]
	private bool IsFrameSkipping()
	{
		return default(bool);
	}

	[Token(Token = "0x60009BC")]
	[Address(RVA = "0xAC4EF4", Offset = "0xAC4EF4", VA = "0xAC4EF4")]
	public bool IsScreaming()
	{
		return default(bool);
	}

	[Token(Token = "0x60009BD")]
	[Address(RVA = "0xAC4F8C", Offset = "0xAC4F8C", VA = "0xAC4F8C")]
	public bool IsIdle()
	{
		return default(bool);
	}

	[Token(Token = "0x60009BE")]
	[Address(RVA = "0xAC5024", Offset = "0xAC5024", VA = "0xAC5024")]
	public bool IsIdle(AnimationConfig.IdleType idleType, bool ignoreTransitions = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60009BF")]
	[Address(RVA = "0xAC50E0", Offset = "0xAC50E0", VA = "0xAC50E0")]
	public bool IsCommunicating()
	{
		return default(bool);
	}

	[Token(Token = "0x60009C0")]
	[Address(RVA = "0xAC51E8", Offset = "0xAC51E8", VA = "0xAC51E8")]
	public void SetScreamingState(PlayMakerFSM patientPlayMakerFSM)
	{
	}

	[Token(Token = "0x60009C1")]
	[Address(RVA = "0xAC5290", Offset = "0xAC5290", VA = "0xAC5290")]
	public void SetIdleState()
	{
	}

	[Token(Token = "0x60009C2")]
	[Address(RVA = "0xAC5328", Offset = "0xAC5328", VA = "0xAC5328", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x60009C3")]
	[Address(RVA = "0xAC5374", Offset = "0xAC5374", VA = "0xAC5374")]
	public float GetMovementDeltaTime()
	{
		return default(float);
	}

	[Token(Token = "0x60009C4")]
	[Address(RVA = "0xAC5430", Offset = "0xAC5430", VA = "0xAC5430")]
	public Vector3 GetAnticipedDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60009C5")]
	[Address(RVA = "0xAC55B4", Offset = "0xAC55B4", VA = "0xAC55B4")]
	public float GetAnticipedSpeed(bool updateLastMovementSpeed)
	{
		return default(float);
	}

	[Token(Token = "0x60009C6")]
	[Address(RVA = "0xAC58A8", Offset = "0xAC58A8", VA = "0xAC58A8")]
	public float GetAdjustedDeltaTime(float newSpeed)
	{
		return default(float);
	}

	[Token(Token = "0x60009C9")]
	[Address(RVA = "0xAC5A10", Offset = "0xAC5A10", VA = "0xAC5A10")]
	public void HelpUp()
	{
	}

	[Token(Token = "0x60009CA")]
	[Address(RVA = "0xAC5A18", Offset = "0xAC5A18", VA = "0xAC5A18")]
	private float GetAnimDirection(Vector3 toDirection)
	{
		return default(float);
	}

	[Token(Token = "0x60009CB")]
	[Address(RVA = "0xAC5C00", Offset = "0xAC5C00", VA = "0xAC5C00")]
	private static bool NeedsPlantAndTurn(Vector3 from, Vector3 to)
	{
		return default(bool);
	}

	[Token(Token = "0x60009CC")]
	[Address(RVA = "0xAC5D0C", Offset = "0xAC5D0C", VA = "0xAC5D0C")]
	protected bool NeedsToDeccelerate(Vector3 newDirection, float newSpeed)
	{
		return default(bool);
	}

	[Token(Token = "0x60009CD")]
	[Address(RVA = "0xAC5F38", Offset = "0xAC5F38", VA = "0xAC5F38")]
	private bool WantsToTurn()
	{
		return default(bool);
	}

	[Token(Token = "0x60009CE")]
	[Address(RVA = "0xAC6010", Offset = "0xAC6010", VA = "0xAC6010")]
	public bool WantsToMove()
	{
		return default(bool);
	}

	[Token(Token = "0x60009D1")]
	[Address(RVA = "0xAC60FC", Offset = "0xAC60FC", VA = "0xAC60FC")]
	private bool IsMoveAnticipationEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60009DE")]
	[Address(RVA = "0xAC6318", Offset = "0xAC6318", VA = "0xAC6318")]
	public Vector3 GetHeadCenterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60009DF")]
	[Address(RVA = "0xAC6360", Offset = "0xAC6360", VA = "0xAC6360")]
	public Vector3 GetTorsoCenterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60009EB")]
	[Address(RVA = "0xAC6600", Offset = "0xAC6600", VA = "0xAC6600")]
	public bool HasReaction()
	{
		return default(bool);
	}

	[Token(Token = "0x60009EC")]
	[Address(RVA = "0xAC6610", Offset = "0xAC6610", VA = "0xAC6610")]
	public bool IsReacting()
	{
		return default(bool);
	}

	[Token(Token = "0x60009ED")]
	[Address(RVA = "0xAC6680", Offset = "0xAC6680", VA = "0xAC6680")]
	public void React(AIMemento memento)
	{
	}

	[Token(Token = "0x60009F4")]
	[Address(RVA = "0xAC6A0C", Offset = "0xAC6A0C", VA = "0xAC6A0C")]
	public void SetAlertness(AlertLevel threatLevel)
	{
	}

	[Token(Token = "0x60009F5")]
	[Address(RVA = "0xAC6A6C", Offset = "0xAC6A6C", VA = "0xAC6A6C")]
	public static AnimationConfig.MovementSpeed SpeedClassificationToMovementSpeed(int classification)
	{
		return default(AnimationConfig.MovementSpeed);
	}

	[Token(Token = "0x60009F6")]
	[Address(RVA = "0xAC6A84", Offset = "0xAC6A84", VA = "0xAC6A84")]
	public void SetBodyDispose()
	{
	}

	[Token(Token = "0x60009F7")]
	[Address(RVA = "0xAC7008", Offset = "0xAC7008", VA = "0xAC7008")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x612ED0", Offset = "0x612ED0")]
	private IEnumerator CorpseFadeOut(float delay, float duration, Material material)
	{
		return null;
	}

	[Token(Token = "0x60009F8")]
	[Address(RVA = "0xAC708C", Offset = "0xAC708C", VA = "0xAC708C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60009F9")]
	[Address(RVA = "0xAC78FC", Offset = "0xAC78FC", VA = "0xAC78FC")]
	private void PatchHierarchalCollisions([Optional] GameObject ragdollGameObject, [Optional] GameObject target)
	{
	}

	[Token(Token = "0x60009FA")]
	[Address(RVA = "0xAC7C40", Offset = "0xAC7C40", VA = "0xAC7C40", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60009FB")]
	[Address(RVA = "0xAC7FA8", Offset = "0xAC7FA8", VA = "0xAC7FA8", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x60009FC")]
	[Address(RVA = "0xAC8014", Offset = "0xAC8014", VA = "0xAC8014")]
	private void UpdateAnimationBlackboard()
	{
	}

	[Token(Token = "0x60009FD")]
	[Address(RVA = "0xAC82C0", Offset = "0xAC82C0", VA = "0xAC82C0")]
	private void DropHandHeldItems(bool left = true, bool right = true)
	{
	}

	[Token(Token = "0x60009FE")]
	[Address(RVA = "0xAC83E4", Offset = "0xAC83E4", VA = "0xAC83E4")]
	private void SnapPositionToNavMesh(ref Vector3 position, Vector3 direction)
	{
	}

	[Token(Token = "0x60009FF")]
	[Address(RVA = "0xAC8680", Offset = "0xAC8680", VA = "0xAC8680")]
	public void SetDestination(Vector3 destination, bool stopAtDestination, float remainingNodeDistance)
	{
	}

	[Token(Token = "0x6000A00")]
	[Address(RVA = "0xAC869C", Offset = "0xAC869C", VA = "0xAC869C")]
	public void ClearDestination()
	{
	}

	[Token(Token = "0x6000A04")]
	[Address(RVA = "0xAC87E0", Offset = "0xAC87E0", VA = "0xAC87E0")]
	public void ArrestStarted(Character arrester)
	{
	}

	[Token(Token = "0x6000A05")]
	[Address(RVA = "0xAC8880", Offset = "0xAC8880", VA = "0xAC8880")]
	public void ArrestCancelled(Character arrester)
	{
	}

	[Token(Token = "0x6000A06")]
	[Address(RVA = "0xAC8920", Offset = "0xAC8920", VA = "0xAC8920")]
	public void PlayBark(Bark bark)
	{
	}

	[Token(Token = "0x6000A07")]
	[Address(RVA = "0xAC67E8", Offset = "0xAC67E8", VA = "0xAC67E8")]
	public void SetBoolTemp(string name, bool value, float time = 0f)
	{
	}

	[Token(Token = "0x6000A08")]
	[Address(RVA = "0xAC89D8", Offset = "0xAC89D8", VA = "0xAC89D8", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0xAC8E50", Offset = "0xAC8E50", VA = "0xAC8E50", Slot = "16")]
	protected override void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0xAC94F0", Offset = "0xAC94F0", VA = "0xAC94F0")]
	private void OnItemEquipped(object sender, Inventory.EquipArgs args)
	{
	}

	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0xAC98F0", Offset = "0xAC98F0", VA = "0xAC98F0")]
	public void UpdateRotation(float maxRotationRate, float deltaTime, Vector3 desired)
	{
	}

	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0xAC5640", Offset = "0xAC5640", VA = "0xAC5640")]
	private float AdjustSpeed(float current, float desired, float deltaTime, bool updateLastMovementSpeed)
	{
		return default(float);
	}

	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0xAC9A80", Offset = "0xAC9A80", VA = "0xAC9A80")]
	private void ApplyVelocity(float deltaTime)
	{
	}

	[Token(Token = "0x6000A10")]
	[Address(RVA = "0xAC9B98", Offset = "0xAC9B98", VA = "0xAC9B98")]
	private void AdjustBoundByDeltaTime(float deltaTime)
	{
	}

	[Token(Token = "0x6000A11")]
	[Address(RVA = "0xAC9E0C", Offset = "0xAC9E0C", VA = "0xAC9E0C")]
	private void EnableRagdoll()
	{
	}

	[Token(Token = "0x6000A12")]
	[Address(RVA = "0xACA3B8", Offset = "0xACA3B8", VA = "0xACA3B8")]
	public void ExtendDisableRigidBodyTime()
	{
	}

	[Token(Token = "0x6000A13")]
	[Address(RVA = "0xACA33C", Offset = "0xACA33C", VA = "0xACA33C")]
	public void EnableRigidBodies()
	{
	}

	[Token(Token = "0x6000A14")]
	[Address(RVA = "0xACA4CC", Offset = "0xACA4CC", VA = "0xACA4CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x612F50", Offset = "0x612F50")]
	private IEnumerator DisableRigidBodiesDelayed()
	{
		return null;
	}

	[Token(Token = "0x6000A15")]
	[Address(RVA = "0xACA538", Offset = "0xACA538", VA = "0xACA538")]
	private void EnableBodyBag()
	{
	}

	[Token(Token = "0x6000A16")]
	[Address(RVA = "0xACAAB4", Offset = "0xACAAB4", VA = "0xACAAB4")]
	private void MapJoints(LocalizationConfiguration localizer, Transform sourceJoint, HierarchicalCollision oldHC)
	{
	}

	[Token(Token = "0x6000A17")]
	[Address(RVA = "0xAC7F68", Offset = "0xAC7F68", VA = "0xAC7F68")]
	private void DisableRigidBodies()
	{
	}

	[Token(Token = "0x6000A18")]
	[Address(RVA = "0xACAFF0", Offset = "0xACAFF0", VA = "0xACAFF0")]
	public void SetAsInstinctObject(bool isInstinctObject)
	{
	}

	[Token(Token = "0x6000A19")]
	[Address(RVA = "0xACB214", Offset = "0xACB214", VA = "0xACB214")]
	public void OnSwitchToCharacterLOD(Animator animator, LODGroup lodGroup)
	{
	}

	[Token(Token = "0x6000A1C")]
	[Address(RVA = "0xACB5E0", Offset = "0xACB5E0", VA = "0xACB5E0")]
	private void AnimEvent(GameObject sender, AnimationEvent ev)
	{
	}

	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0xACB700", Offset = "0xACB700", VA = "0xACB700")]
	public void PlaySFX(SoundContainer soundContainer)
	{
	}

	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0xACB824", Offset = "0xACB824", VA = "0xACB824")]
	private Material AddMaterial(Material newMaterial)
	{
		return null;
	}

	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0xACBB30", Offset = "0xACBB30", VA = "0xACBB30")]
	public void Freeze(Damage damage, Bullet.Hit hit)
	{
	}

	[Token(Token = "0x6000A20")]
	[Address(RVA = "0xACBB98", Offset = "0xACBB98", VA = "0xACBB98")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x612FD0", Offset = "0x612FD0")]
	private IEnumerator Freezing(Damage damage, float duration, Bullet.Hit hit)
	{
		return null;
	}

	[Token(Token = "0x6000A21")]
	[Address(RVA = "0xAC9428", Offset = "0xAC9428", VA = "0xAC9428")]
	private void StartBurning()
	{
	}

	[Token(Token = "0x6000A22")]
	[Address(RVA = "0xACBC44", Offset = "0xACBC44", VA = "0xACBC44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x613030", Offset = "0x613030")]
	private IEnumerator Burning(float duration)
	{
		return null;
	}

	[Token(Token = "0x6000A23")]
	[Address(RVA = "0xACBCC0", Offset = "0xACBCC0", VA = "0xACBCC0")]
	public void Suicide(Vector3 direction)
	{
	}

	[Token(Token = "0x6000A24")]
	[Address(RVA = "0xACBEA4", Offset = "0xACBEA4", VA = "0xACBEA4")]
	private void SetVerticalDamageOnly(bool isVerticalOnly)
	{
	}

	[Token(Token = "0x6000A25")]
	[Address(RVA = "0xACBFC0", Offset = "0xACBFC0", VA = "0xACBFC0")]
	internal void ResetPossession(bool doEnableBodyBag)
	{
	}

	[Token(Token = "0x6000A26")]
	[Address(RVA = "0xACBFF8", Offset = "0xACBFF8", VA = "0xACBFF8")]
	public void Possess()
	{
	}

	[Token(Token = "0x6000A27")]
	[Address(RVA = "0xACC280", Offset = "0xACC280", VA = "0xACC280")]
	public void SetBodyAsDominoKillInOneShoot(bool value, float delay)
	{
	}

	[Token(Token = "0x6000A28")]
	[Address(RVA = "0xACC308", Offset = "0xACC308", VA = "0xACC308")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x613090", Offset = "0x613090")]
	private IEnumerator DoStopBodyAsDominoKillInOneShoot(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000A29")]
	[Address(RVA = "0xACC384", Offset = "0xACC384", VA = "0xACC384")]
	public void SetNextRandomAnim()
	{
	}

	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0xACC554", Offset = "0xACC554", VA = "0xACC554")]
	public void AccumulateForce(Vector3 force, Vector3 position, ForceMode mode, Rigidbody rigidBody)
	{
	}

	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0xACC570", Offset = "0xACC570", VA = "0xACC570")]
	public ThirdPersonCharacter()
	{
	}
}
