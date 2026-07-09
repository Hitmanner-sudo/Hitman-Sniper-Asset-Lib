using HutongGames.PlayMaker.TweenEnums;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011D9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9D54", Offset = "0x5A9D54")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9D54", Offset = "0x5A9D54")]
	public class TweenRotation : TweenComponentBase<Transform>
	{
		[Token(Token = "0x4005556")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFA34", Offset = "0x5FFA34")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5FFA34", Offset = "0x5FFA34")]
		[Attribute(Name = "ActionSection", RVA = "0x5FFA34", Offset = "0x5FFA34")]
		public RotationOptions fromOptions;

		[Token(Token = "0x4005557")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFAB8", Offset = "0x5FFAB8")]
		public FsmGameObject fromTarget;

		[Token(Token = "0x4005558")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFAF0", Offset = "0x5FFAF0")]
		public FsmVector3 fromRotation;

		[Token(Token = "0x4005559")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "ActionSection", RVA = "0x5FFB28", Offset = "0x5FFB28")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5FFB28", Offset = "0x5FFB28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFB28", Offset = "0x5FFB28")]
		public RotationOptions toOptions;

		[Token(Token = "0x400555A")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFBAC", Offset = "0x5FFBAC")]
		public FsmGameObject toTarget;

		[Token(Token = "0x400555B")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFBE4", Offset = "0x5FFBE4")]
		public FsmVector3 toRotation;

		[Token(Token = "0x400555C")]
		[FieldOffset(Offset = "0xF8")]
		private Transform transform;

		[Token(Token = "0x400555D")]
		[FieldOffset(Offset = "0x100")]
		private Transform fromTransform;

		[Token(Token = "0x400555E")]
		[FieldOffset(Offset = "0x108")]
		private Transform toTransform;

		[Token(Token = "0x400555F")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFC1C", Offset = "0x5FFC1C")]
		private Quaternion _003CStartRotation_003Ek__BackingField;

		[Token(Token = "0x4005560")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFC2C", Offset = "0x5FFC2C")]
		private Quaternion _003CEndRotation_003Ek__BackingField;

		[Token(Token = "0x4005561")]
		[FieldOffset(Offset = "0x130")]
		private Quaternion midRotation;

		[Token(Token = "0x17000C4B")]
		public Quaternion StartRotation
		{
			[Token(Token = "0x60068EF")]
			[Address(RVA = "0x1572F64", Offset = "0x1572F64", VA = "0x1572F64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C1C0", Offset = "0x62C1C0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60068F0")]
			[Address(RVA = "0x1572F78", Offset = "0x1572F78", VA = "0x1572F78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C1D0", Offset = "0x62C1D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C4C")]
		public Quaternion EndRotation
		{
			[Token(Token = "0x60068F1")]
			[Address(RVA = "0x1572F8C", Offset = "0x1572F8C", VA = "0x1572F8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C1E0", Offset = "0x62C1E0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60068F2")]
			[Address(RVA = "0x1572FA0", Offset = "0x1572FA0", VA = "0x1572FA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C1F0", Offset = "0x62C1F0")]
			private set
			{
			}
		}

		[Token(Token = "0x60068F3")]
		[Address(RVA = "0x1572FB4", Offset = "0x1572FB4", VA = "0x1572FB4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60068F4")]
		[Address(RVA = "0x1573018", Offset = "0x1573018", VA = "0x1573018", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60068F5")]
		[Address(RVA = "0x15731A4", Offset = "0x15731A4", VA = "0x15731A4")]
		private void InitStartRotation()
		{
		}

		[Token(Token = "0x60068F6")]
		[Address(RVA = "0x1573208", Offset = "0x1573208", VA = "0x1573208")]
		private void InitEndRotation()
		{
		}

		[Token(Token = "0x60068F7")]
		[Address(RVA = "0x15732C0", Offset = "0x15732C0", VA = "0x15732C0")]
		private void UpdateStartRotation()
		{
		}

		[Token(Token = "0x60068F8")]
		[Address(RVA = "0x15732D4", Offset = "0x15732D4", VA = "0x15732D4")]
		private void UpdateEndRotation()
		{
		}

		[Token(Token = "0x60068F9")]
		[Address(RVA = "0x15732E8", Offset = "0x15732E8", VA = "0x15732E8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60068FA")]
		[Address(RVA = "0x157333C", Offset = "0x157333C", VA = "0x157333C", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068FB")]
		[Address(RVA = "0x1573400", Offset = "0x1573400", VA = "0x1573400")]
		public TweenRotation()
		{
		}
	}
}
