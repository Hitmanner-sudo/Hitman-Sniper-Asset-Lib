using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011AD")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9248", Offset = "0x5A9248")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9248", Offset = "0x5A9248")]
	public class Rotate : FsmStateAction
	{
		[Token(Token = "0x400543B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCAE0", Offset = "0x5FCAE0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400543C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCB2C", Offset = "0x5FCB2C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FCB2C", Offset = "0x5FCB2C")]
		public FsmVector3 vector;

		[Token(Token = "0x400543D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCB7C", Offset = "0x5FCB7C")]
		public FsmFloat xAngle;

		[Token(Token = "0x400543E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCBB4", Offset = "0x5FCBB4")]
		public FsmFloat yAngle;

		[Token(Token = "0x400543F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCBEC", Offset = "0x5FCBEC")]
		public FsmFloat zAngle;

		[Token(Token = "0x4005440")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCC24", Offset = "0x5FCC24")]
		public Space space;

		[Token(Token = "0x4005441")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCC5C", Offset = "0x5FCC5C")]
		public bool perSecond;

		[Token(Token = "0x4005442")]
		[FieldOffset(Offset = "0x7D")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCC94", Offset = "0x5FCC94")]
		public bool everyFrame;

		[Token(Token = "0x4005443")]
		[FieldOffset(Offset = "0x7E")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCCCC", Offset = "0x5FCCCC")]
		public bool lateUpdate;

		[Token(Token = "0x4005444")]
		[FieldOffset(Offset = "0x7F")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCD04", Offset = "0x5FCD04")]
		public bool fixedUpdate;

		[Token(Token = "0x6006811")]
		[Address(RVA = "0xBA4840", Offset = "0xBA4840", VA = "0xBA4840", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006812")]
		[Address(RVA = "0xBA4904", Offset = "0xBA4904", VA = "0xBA4904", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006813")]
		[Address(RVA = "0xBA4964", Offset = "0xBA4964", VA = "0xBA4964", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006814")]
		[Address(RVA = "0xBA4BC4", Offset = "0xBA4BC4", VA = "0xBA4BC4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006815")]
		[Address(RVA = "0xBA4BDC", Offset = "0xBA4BDC", VA = "0xBA4BDC", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006816")]
		[Address(RVA = "0xBA4C24", Offset = "0xBA4C24", VA = "0xBA4C24", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006817")]
		[Address(RVA = "0xBA49B4", Offset = "0xBA49B4", VA = "0xBA49B4")]
		private void DoRotate()
		{
		}

		[Token(Token = "0x6006818")]
		[Address(RVA = "0xBA4C6C", Offset = "0xBA4C6C", VA = "0xBA4C6C")]
		public Rotate()
		{
		}
	}
}
