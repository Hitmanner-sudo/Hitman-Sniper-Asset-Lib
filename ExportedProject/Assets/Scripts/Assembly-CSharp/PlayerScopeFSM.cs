using System;
using Il2CppDummyDll;

[Token(Token = "0x200048A")]
public class PlayerScopeFSM : PlayerFSM
{
	[Token(Token = "0x200048B")]
	public class Aim : BaseState
	{
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x8D5E78", Offset = "0x8D5E78", VA = "0x8D5E78", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x8D5E7C", Offset = "0x8D5E7C", VA = "0x8D5E7C", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x8D5E80", Offset = "0x8D5E80", VA = "0x8D5E80", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x8D5E84", Offset = "0x8D5E84", VA = "0x8D5E84")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x617E20", Offset = "0x617E20")]
		protected static bool TestShooting(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x8D5F10", Offset = "0x8D5F10", VA = "0x8D5F10")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x617E84", Offset = "0x617E84")]
		protected static bool TestEnterCunning(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x8D5FDC", Offset = "0x8D5FDC", VA = "0x8D5FDC")]
		public Aim()
		{
		}
	}

	[Token(Token = "0x200048C")]
	public class CunningAddTag : BaseState
	{
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x8D5FE4", Offset = "0x8D5FE4", VA = "0x8D5FE4", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x8D611C", Offset = "0x8D611C", VA = "0x8D611C", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x8D6120", Offset = "0x8D6120", VA = "0x8D6120")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x617EE8", Offset = "0x617EE8")]
		protected static bool TestCunningShoot(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x8D61CC", Offset = "0x8D61CC", VA = "0x8D61CC")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x617F4C", Offset = "0x617F4C")]
		protected static bool TestCunningAim(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x8D61D4", Offset = "0x8D61D4", VA = "0x8D61D4")]
		public CunningAddTag()
		{
		}
	}

	[Token(Token = "0x200048D")]
	public class CunningAim : BaseState
	{
		[Token(Token = "0x6001B92")]
		[Address(RVA = "0x8D61DC", Offset = "0x8D61DC", VA = "0x8D61DC", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001B93")]
		[Address(RVA = "0x8D6220", Offset = "0x8D6220", VA = "0x8D6220", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001B94")]
		[Address(RVA = "0x8D6224", Offset = "0x8D6224", VA = "0x8D6224", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6001B95")]
		[Address(RVA = "0x8D6264", Offset = "0x8D6264", VA = "0x8D6264")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x617FB0", Offset = "0x617FB0")]
		protected static bool TestAddTag(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B96")]
		[Address(RVA = "0x8D6328", Offset = "0x8D6328", VA = "0x8D6328")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x618014", Offset = "0x618014")]
		protected static bool TestLeaveCunningMode(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B97")]
		[Address(RVA = "0x8D63EC", Offset = "0x8D63EC", VA = "0x8D63EC")]
		public CunningAim()
		{
		}
	}

	[Token(Token = "0x200048E")]
	public class EnterCunning : BaseState
	{
		[Token(Token = "0x40018BE")]
		private const float SLOW_DOWN_DURATION = 0.5f;

		[Token(Token = "0x40018BF")]
		[FieldOffset(Offset = "0x20")]
		private Timer _slowdownTimer;

		[Token(Token = "0x40018C0")]
		[FieldOffset(Offset = "0x28")]
		private float _initialTimescale;

		[Token(Token = "0x6001B98")]
		[Address(RVA = "0x8D63F4", Offset = "0x8D63F4", VA = "0x8D63F4", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001B99")]
		[Address(RVA = "0x8D65B0", Offset = "0x8D65B0", VA = "0x8D65B0", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001B9A")]
		[Address(RVA = "0x8D6688", Offset = "0x8D6688", VA = "0x8D6688")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x618078", Offset = "0x618078")]
		protected static bool TestDoneSlowdown(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B9B")]
		[Address(RVA = "0x8D67A8", Offset = "0x8D67A8", VA = "0x8D67A8")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6180DC", Offset = "0x6180DC")]
		protected static bool TestCancel(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x8D6854", Offset = "0x8D6854", VA = "0x8D6854")]
		public EnterCunning()
		{
		}
	}

	[Token(Token = "0x200048F")]
	public class LeaveCunning : BaseState
	{
		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x8D685C", Offset = "0x8D685C", VA = "0x8D685C", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x8D6C74", Offset = "0x8D6C74", VA = "0x8D6C74", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x8D6A28", Offset = "0x8D6A28", VA = "0x8D6A28")]
		private void DeactivateCunningPowerUp()
		{
		}

		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x8D6C78", Offset = "0x8D6C78", VA = "0x8D6C78")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x618140", Offset = "0x618140")]
		protected static bool TestAim(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x8D6C80", Offset = "0x8D6C80", VA = "0x8D6C80")]
		public LeaveCunning()
		{
		}
	}

	[Token(Token = "0x2000490")]
	public class Shoot : BaseState
	{
		[Token(Token = "0x40018C1")]
		[FieldOffset(Offset = "0x20")]
		private bool _wasHoldingBreathWhenShooting;

		[Token(Token = "0x40018C2")]
		[FieldOffset(Offset = "0x28")]
		private Bullet _holdingBreathBulletShoot;

		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x8D6C88", Offset = "0x8D6C88", VA = "0x8D6C88", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x8D6DC0", Offset = "0x8D6DC0", VA = "0x8D6DC0", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x8D6F5C", Offset = "0x8D6F5C", VA = "0x8D6F5C", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x8D6FF8", Offset = "0x8D6FF8", VA = "0x8D6FF8")]
		private void OnBulletDied(object sender, Bullet.BulletDiedArgs e)
		{
		}

		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x8D6F14", Offset = "0x8D6F14", VA = "0x8D6F14")]
		private void StopSlowMotion()
		{
		}

		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x8D70A0", Offset = "0x8D70A0", VA = "0x8D70A0")]
		[AttributeAttribute(Name = "TransitionAttribute", RVA = "0x6181A4", Offset = "0x6181A4")]
		protected static bool TestEndShooting(FSMState instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x8D7140", Offset = "0x8D7140", VA = "0x8D7140")]
		public Shoot()
		{
		}
	}

	[Token(Token = "0x6001B86")]
	[Address(RVA = "0xAB6898", Offset = "0xAB6898", VA = "0xAB6898")]
	public PlayerScopeFSM(Type initialState, PlayerController player)
	{
	}
}
