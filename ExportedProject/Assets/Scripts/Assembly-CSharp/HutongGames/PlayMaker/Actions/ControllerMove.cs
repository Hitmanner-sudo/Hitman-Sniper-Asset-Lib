using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F48")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C5A0", Offset = "0x59C5A0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C5A0", Offset = "0x59C5A0")]
	public class ControllerMove : FsmStateAction
	{
		[Token(Token = "0x4004836")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDEB0", Offset = "0x5CDEB0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CDEB0", Offset = "0x5CDEB0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004837")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDF44", Offset = "0x5CDF44")]
		public FsmVector3 moveVector;

		[Token(Token = "0x4004838")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDF90", Offset = "0x5CDF90")]
		public Space space;

		[Token(Token = "0x4004839")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CDFC8", Offset = "0x5CDFC8")]
		public FsmBool perSecond;

		[Token(Token = "0x400483A")]
		[FieldOffset(Offset = "0x70")]
		private GameObject previousGo;

		[Token(Token = "0x400483B")]
		[FieldOffset(Offset = "0x78")]
		private CharacterController controller;

		[Token(Token = "0x6005D80")]
		[Address(RVA = "0xD7DFE0", Offset = "0xD7DFE0", VA = "0xD7DFE0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D81")]
		[Address(RVA = "0xD7E064", Offset = "0xD7E064", VA = "0xD7E064", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D82")]
		[Address(RVA = "0xD7E280", Offset = "0xD7E280", VA = "0xD7E280")]
		public ControllerMove()
		{
		}
	}
}
