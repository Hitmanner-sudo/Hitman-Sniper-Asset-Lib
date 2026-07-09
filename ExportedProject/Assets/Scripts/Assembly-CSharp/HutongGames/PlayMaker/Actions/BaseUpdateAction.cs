using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F35")]
	public abstract class BaseUpdateAction : FsmStateAction
	{
		[Token(Token = "0x2000F36")]
		public enum UpdateType
		{
			[Token(Token = "0x40047C3")]
			OnUpdate = 0,
			[Token(Token = "0x40047C4")]
			OnLateUpdate = 1,
			[Token(Token = "0x40047C5")]
			OnFixedUpdate = 2
		}

		[Token(Token = "0x40047C0")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC528", Offset = "0x5CC528")]
		[Attribute(Name = "ActionSection", RVA = "0x5CC528", Offset = "0x5CC528")]
		public bool everyFrame;

		[Token(Token = "0x40047C1")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC588", Offset = "0x5CC588")]
		public UpdateType updateType;

		[Token(Token = "0x6005D29")]
		public abstract void OnActionUpdate();

		[Token(Token = "0x6005D2A")]
		[Address(RVA = "0xC0FD60", Offset = "0xC0FD60", VA = "0xC0FD60", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D2B")]
		[Address(RVA = "0xC0FD6C", Offset = "0xC0FD6C", VA = "0xC0FD6C", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005D2C")]
		[Address(RVA = "0xC0FDC4", Offset = "0xC0FDC4", VA = "0xC0FDC4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D2D")]
		[Address(RVA = "0xC0FE18", Offset = "0xC0FE18", VA = "0xC0FE18", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6005D2E")]
		[Address(RVA = "0xC0FE70", Offset = "0xC0FE70", VA = "0xC0FE70", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6005D2F")]
		[Address(RVA = "0xC0FEC8", Offset = "0xC0FEC8", VA = "0xC0FEC8")]
		protected BaseUpdateAction()
		{
		}
	}
}
