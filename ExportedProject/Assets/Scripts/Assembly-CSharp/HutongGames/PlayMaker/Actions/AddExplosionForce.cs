using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200106B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1FE0", Offset = "0x5A1FE0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1FE0", Offset = "0x5A1FE0")]
	public class AddExplosionForce : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004D0D")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E1388", Offset = "0x5E1388")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1388", Offset = "0x5E1388")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004D0E")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E141C", Offset = "0x5E141C")]
		public FsmVector3 center;

		[Token(Token = "0x4004D0F")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1468", Offset = "0x5E1468")]
		public FsmFloat force;

		[Token(Token = "0x4004D10")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E14B4", Offset = "0x5E14B4")]
		[RequiredField]
		public FsmFloat radius;

		[Token(Token = "0x4004D11")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1500", Offset = "0x5E1500")]
		public FsmFloat upwardsModifier;

		[Token(Token = "0x4004D12")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1538", Offset = "0x5E1538")]
		public ForceMode forceMode;

		[Token(Token = "0x4004D13")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1570", Offset = "0x5E1570")]
		public bool everyFrame;

		[Token(Token = "0x6006210")]
		[Address(RVA = "0xD5C498", Offset = "0xD5C498", VA = "0xD5C498", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006211")]
		[Address(RVA = "0xD5C520", Offset = "0xD5C520", VA = "0xD5C520", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006212")]
		[Address(RVA = "0xD5C540", Offset = "0xD5C540", VA = "0xD5C540", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006213")]
		[Address(RVA = "0xD5C6DC", Offset = "0xD5C6DC", VA = "0xD5C6DC", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006214")]
		[Address(RVA = "0xD5C57C", Offset = "0xD5C57C", VA = "0xD5C57C")]
		private void DoAddExplosionForce()
		{
		}

		[Token(Token = "0x6006215")]
		[Address(RVA = "0xD5C6E0", Offset = "0xD5C6E0", VA = "0xD5C6E0")]
		public AddExplosionForce()
		{
		}
	}
}
