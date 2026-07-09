using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200106C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2030", Offset = "0x5A2030")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2030", Offset = "0x5A2030")]
	public class AddForce : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004D14")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E15A8", Offset = "0x5E15A8")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E15A8", Offset = "0x5E15A8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D15")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E163C", Offset = "0x5E163C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E163C", Offset = "0x5E163C")]
		public FsmVector3 atPosition;

		[Token(Token = "0x4004D16")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E168C", Offset = "0x5E168C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E168C", Offset = "0x5E168C")]
		public FsmVector3 vector;

		[Token(Token = "0x4004D17")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E16DC", Offset = "0x5E16DC")]
		public FsmFloat x;

		[Token(Token = "0x4004D18")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1714", Offset = "0x5E1714")]
		public FsmFloat y;

		[Token(Token = "0x4004D19")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E174C", Offset = "0x5E174C")]
		public FsmFloat z;

		[Token(Token = "0x4004D1A")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1784", Offset = "0x5E1784")]
		public Space space;

		[Token(Token = "0x4004D1B")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E17BC", Offset = "0x5E17BC")]
		public ForceMode forceMode;

		[Token(Token = "0x4004D1C")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E17F4", Offset = "0x5E17F4")]
		public bool everyFrame;

		[Token(Token = "0x6006216")]
		[Address(RVA = "0xD5C72C", Offset = "0xD5C72C", VA = "0xD5C72C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006217")]
		[Address(RVA = "0xD5C820", Offset = "0xD5C820", VA = "0xD5C820", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006218")]
		[Address(RVA = "0xD5C840", Offset = "0xD5C840", VA = "0xD5C840", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006219")]
		[Address(RVA = "0xD5CAC4", Offset = "0xD5CAC4", VA = "0xD5CAC4", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600621A")]
		[Address(RVA = "0xD5C87C", Offset = "0xD5C87C", VA = "0xD5C87C")]
		private void DoAddForce()
		{
		}

		[Token(Token = "0x600621B")]
		[Address(RVA = "0xD5CAC8", Offset = "0xD5CAC8", VA = "0xD5CAC8")]
		public AddForce()
		{
		}
	}
}
