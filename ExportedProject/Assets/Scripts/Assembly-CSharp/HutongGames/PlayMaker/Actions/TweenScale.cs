using HutongGames.PlayMaker.TweenEnums;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011DA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9DA4", Offset = "0x5A9DA4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9DA4", Offset = "0x5A9DA4")]
	public class TweenScale : TweenComponentBase<Transform>
	{
		[Token(Token = "0x4005562")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ActionSection", RVA = "0x5FFC3C", Offset = "0x5FFC3C")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5FFC3C", Offset = "0x5FFC3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFC3C", Offset = "0x5FFC3C")]
		public ScaleOptions fromOptions;

		[Token(Token = "0x4005563")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFCC0", Offset = "0x5FFCC0")]
		public FsmGameObject fromTarget;

		[Token(Token = "0x4005564")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFCF8", Offset = "0x5FFCF8")]
		public FsmVector3 fromScale;

		[Token(Token = "0x4005565")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5FFD30", Offset = "0x5FFD30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFD30", Offset = "0x5FFD30")]
		[Attribute(Name = "ActionSection", RVA = "0x5FFD30", Offset = "0x5FFD30")]
		public ScaleOptions toOptions;

		[Token(Token = "0x4005566")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFDB4", Offset = "0x5FFDB4")]
		public FsmGameObject toTarget;

		[Token(Token = "0x4005567")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FFDEC", Offset = "0x5FFDEC")]
		public FsmVector3 toScale;

		[Token(Token = "0x4005568")]
		[FieldOffset(Offset = "0xF8")]
		private Transform transform;

		[Token(Token = "0x4005569")]
		[FieldOffset(Offset = "0x100")]
		private Transform fromTransform;

		[Token(Token = "0x400556A")]
		[FieldOffset(Offset = "0x108")]
		private Transform toTransform;

		[Token(Token = "0x400556B")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFE24", Offset = "0x5FFE24")]
		private Vector3 _003CStartScale_003Ek__BackingField;

		[Token(Token = "0x400556C")]
		[FieldOffset(Offset = "0x11C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFE34", Offset = "0x5FFE34")]
		private Vector3 _003CEndScale_003Ek__BackingField;

		[Token(Token = "0x17000C4D")]
		public Vector3 StartScale
		{
			[Token(Token = "0x60068FC")]
			[Address(RVA = "0x15737D0", Offset = "0x15737D0", VA = "0x15737D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C200", Offset = "0x62C200")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60068FD")]
			[Address(RVA = "0x15737E0", Offset = "0x15737E0", VA = "0x15737E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C210", Offset = "0x62C210")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C4E")]
		public Vector3 EndScale
		{
			[Token(Token = "0x60068FE")]
			[Address(RVA = "0x15737F0", Offset = "0x15737F0", VA = "0x15737F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C220", Offset = "0x62C220")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60068FF")]
			[Address(RVA = "0x1573800", Offset = "0x1573800", VA = "0x1573800")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62C230", Offset = "0x62C230")]
			private set
			{
			}
		}

		[Token(Token = "0x6006900")]
		[Address(RVA = "0x1573810", Offset = "0x1573810", VA = "0x1573810", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006901")]
		[Address(RVA = "0x15738EC", Offset = "0x15738EC", VA = "0x15738EC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006902")]
		[Address(RVA = "0x1573A78", Offset = "0x1573A78", VA = "0x1573A78")]
		private void InitStartScale()
		{
		}

		[Token(Token = "0x6006903")]
		[Address(RVA = "0x1573AF8", Offset = "0x1573AF8", VA = "0x1573AF8")]
		private void InitEndScale()
		{
		}

		[Token(Token = "0x6006904")]
		[Address(RVA = "0x1573B7C", Offset = "0x1573B7C", VA = "0x1573B7C")]
		private void UpdateStartScale()
		{
		}

		[Token(Token = "0x6006905")]
		[Address(RVA = "0x1573B98", Offset = "0x1573B98", VA = "0x1573B98")]
		private void UpdateEndScale()
		{
		}

		[Token(Token = "0x6006906")]
		[Address(RVA = "0x1573BB4", Offset = "0x1573BB4", VA = "0x1573BB4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006907")]
		[Address(RVA = "0x1573C08", Offset = "0x1573C08", VA = "0x1573C08", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x6006908")]
		[Address(RVA = "0x1573CA0", Offset = "0x1573CA0", VA = "0x1573CA0")]
		public TweenScale()
		{
		}
	}
}
