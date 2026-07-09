using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F39")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C128", Offset = "0x59C128")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C128", Offset = "0x59C128")]
	public class ClampOrthographicView : ComponentAction<Camera>
	{
		[Token(Token = "0x2000F3A")]
		public enum ScreenPlane
		{
			[Token(Token = "0x40047DD")]
			XY = 0,
			[Token(Token = "0x40047DE")]
			XZ = 1
		}

		[Token(Token = "0x40047D4")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC800", Offset = "0x5CC800")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40047D5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC84C", Offset = "0x5CC84C")]
		public ScreenPlane view;

		[Token(Token = "0x40047D6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC884", Offset = "0x5CC884")]
		public FsmFloat minX;

		[Token(Token = "0x40047D7")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC8BC", Offset = "0x5CC8BC")]
		public FsmFloat maxX;

		[Token(Token = "0x40047D8")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC8F4", Offset = "0x5CC8F4")]
		public FsmFloat minY;

		[Token(Token = "0x40047D9")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC92C", Offset = "0x5CC92C")]
		public FsmFloat maxY;

		[Token(Token = "0x40047DA")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC964", Offset = "0x5CC964")]
		public bool everyFrame;

		[Token(Token = "0x40047DB")]
		[FieldOffset(Offset = "0x99")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CC99C", Offset = "0x5CC99C")]
		public bool lateUpdate;

		[Token(Token = "0x6005D3A")]
		[Address(RVA = "0xB01054", Offset = "0xB01054", VA = "0xB01054", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D3B")]
		[Address(RVA = "0xB01134", Offset = "0xB01134", VA = "0xB01134", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005D3C")]
		[Address(RVA = "0xB01160", Offset = "0xB01160", VA = "0xB01160", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D3D")]
		[Address(RVA = "0xB01468", Offset = "0xB01468", VA = "0xB01468", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D3E")]
		[Address(RVA = "0xB01478", Offset = "0xB01478", VA = "0xB01478", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6005D3F")]
		[Address(RVA = "0xB011A8", Offset = "0xB011A8", VA = "0xB011A8")]
		private void DoClampPosition()
		{
		}

		[Token(Token = "0x6005D40")]
		[Address(RVA = "0xB014C4", Offset = "0xB014C4", VA = "0xB014C4")]
		public ClampOrthographicView()
		{
		}
	}
}
