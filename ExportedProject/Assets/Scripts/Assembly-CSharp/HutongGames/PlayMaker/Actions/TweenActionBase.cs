using System;
using HutongGames.PlayMaker.TweenEnums;
using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011C4")]
	[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x5A9928", Offset = "0x5A9928")]
	public abstract class TweenActionBase : BaseUpdateAction
	{
		[Token(Token = "0x40054D5")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FEF18", Offset = "0x5FEF18")]
		[AttributeAttribute(Name = "ActionSection", RVA = "0x5FEF18", Offset = "0x5FEF18")]
		public FsmFloat startDelay;

		[Token(Token = "0x40054D6")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FEF78", Offset = "0x5FEF78")]
		[AttributeAttribute(Name = "ObjectTypeAttribute", RVA = "0x5FEF78", Offset = "0x5FEF78")]
		[AttributeAttribute(Name = "PreviewFieldAttribute", RVA = "0x5FEF78", Offset = "0x5FEF78")]
		public FsmEnum easeType;

		[Token(Token = "0x40054D7")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HideIfAttribute", RVA = "0x5FF020", Offset = "0x5FF020")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF020", Offset = "0x5FF020")]
		public FsmAnimationCurve customCurve;

		[Token(Token = "0x40054D8")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF080", Offset = "0x5FF080")]
		public FsmFloat time;

		[Token(Token = "0x40054D9")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF0B8", Offset = "0x5FF0B8")]
		public FsmBool realTime;

		[Token(Token = "0x40054DA")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF0F0", Offset = "0x5FF0F0")]
		public LoopType loopType;

		[Token(Token = "0x40054DB")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5FF128", Offset = "0x5FF128")]
		public FsmEvent finishEvent;

		[NonSerialized]
		[Token(Token = "0x40054DC")]
		[FieldOffset(Offset = "0x88")]
		public float normalizedTime;

		[Token(Token = "0x40054DD")]
		[FieldOffset(Offset = "0x8C")]
		protected bool tweenStarted;

		[Token(Token = "0x40054DE")]
		[FieldOffset(Offset = "0x8D")]
		protected bool tweenFinished;

		[Token(Token = "0x40054DF")]
		[FieldOffset(Offset = "0x90")]
		protected float currentTime;

		[Token(Token = "0x40054E0")]
		[FieldOffset(Offset = "0x94")]
		protected bool playPreview;

		[Token(Token = "0x40054E1")]
		[FieldOffset(Offset = "0x98")]
		private EasingFunction.Ease cachedEase;

		[Token(Token = "0x40054E2")]
		[FieldOffset(Offset = "0xA0")]
		private EasingFunction.Function func;

		[Token(Token = "0x40054E3")]
		[FieldOffset(Offset = "0x0")]
		private static bool showPreviewCurve;

		[Token(Token = "0x40054E4")]
		[FieldOffset(Offset = "0xA8")]
		private bool reverse;

		[Token(Token = "0x17000C44")]
		public EasingFunction.Function easingFunction
		{
			[Token(Token = "0x6006891")]
			[Address(RVA = "0xCAB708", Offset = "0xCAB708", VA = "0xCAB708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006892")]
		[Address(RVA = "0xCAB7B0", Offset = "0xCAB7B0", VA = "0xCAB7B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006893")]
		[Address(RVA = "0xCAB800", Offset = "0xCAB800", VA = "0xCAB800", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006894")]
		[Address(RVA = "0xCAB81C", Offset = "0xCAB81C", VA = "0xCAB81C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6006895")]
		protected abstract void DoTween();

		[Token(Token = "0x6006896")]
		[Address(RVA = "0xCABA3C", Offset = "0xCABA3C", VA = "0xCABA3C")]
		protected TweenActionBase()
		{
		}
	}
}
