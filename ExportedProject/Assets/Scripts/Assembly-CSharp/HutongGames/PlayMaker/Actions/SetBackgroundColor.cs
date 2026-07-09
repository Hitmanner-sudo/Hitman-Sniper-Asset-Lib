using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F3E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C2D0", Offset = "0x59C2D0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C2D0", Offset = "0x59C2D0")]
	public class SetBackgroundColor : ComponentAction<Camera>
	{
		[Token(Token = "0x40047EE")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CCD98", Offset = "0x5CCD98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCD98", Offset = "0x5CCD98")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40047EF")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCE2C", Offset = "0x5CCE2C")]
		public FsmColor backgroundColor;

		[Token(Token = "0x40047F0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCE78", Offset = "0x5CCE78")]
		public bool everyFrame;

		[Token(Token = "0x6005D4E")]
		[Address(RVA = "0x10382A4", Offset = "0x10382A4", VA = "0x10382A4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D4F")]
		[Address(RVA = "0x10382DC", Offset = "0x10382DC", VA = "0x10382DC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D50")]
		[Address(RVA = "0x10383CC", Offset = "0x10383CC", VA = "0x10383CC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D51")]
		[Address(RVA = "0x1038318", Offset = "0x1038318", VA = "0x1038318")]
		private void DoSetBackgroundColor()
		{
		}

		[Token(Token = "0x6005D52")]
		[Address(RVA = "0x10383D0", Offset = "0x10383D0", VA = "0x10383D0")]
		public SetBackgroundColor()
		{
		}
	}
}
