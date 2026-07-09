using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Mathos.Parser;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001067")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1ED0", Offset = "0x5A1ED0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1ED0", Offset = "0x5A1ED0")]
	public class MathExpression : FsmStateAction
	{
		[Token(Token = "0x2001068")]
		public class Property
		{
			[Token(Token = "0x4004D04")]
			[FieldOffset(Offset = "0x10")]
			public string path;

			[Token(Token = "0x6006205")]
			[Address(RVA = "0x8C5D80", Offset = "0x8C5D80", VA = "0x8C5D80")]
			public Property()
			{
			}
		}

		[Token(Token = "0x4004CFC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E0F84", Offset = "0x5E0F84")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0F84", Offset = "0x5E0F84")]
		public FsmString expression;

		[Token(Token = "0x4004CFD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0FD4", Offset = "0x5E0FD4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E0FD4", Offset = "0x5E0FD4")]
		public FsmFloat storeResultAsFloat;

		[Token(Token = "0x4004CFE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1024", Offset = "0x5E1024")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E1024", Offset = "0x5E1024")]
		public FsmInt storeResultAsInt;

		[Token(Token = "0x4004CFF")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E1074", Offset = "0x5E1074")]
		public bool everyFrame;

		[Token(Token = "0x4004D00")]
		[FieldOffset(Offset = "0x70")]
		private MathParser parser;

		[Token(Token = "0x4004D01")]
		[FieldOffset(Offset = "0x78")]
		private string cachedExpression;

		[Token(Token = "0x4004D02")]
		[FieldOffset(Offset = "0x80")]
		private ReadOnlyCollection<string> tokens;

		[Token(Token = "0x4004D03")]
		[FieldOffset(Offset = "0x88")]
		private readonly List<NamedVariable> usedVariables;

		[Token(Token = "0x60061FE")]
		[Address(RVA = "0x9B06C0", Offset = "0x9B06C0", VA = "0x9B06C0", Slot = "30")]
		public override void Awake()
		{
		}

		[Token(Token = "0x60061FF")]
		[Address(RVA = "0x9B28BC", Offset = "0x9B28BC", VA = "0x9B28BC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006200")]
		[Address(RVA = "0x9B2978", Offset = "0x9B2978", VA = "0x9B2978", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006201")]
		[Address(RVA = "0x9B28F8", Offset = "0x9B28F8", VA = "0x9B28F8")]
		private void DoMathExpression()
		{
		}

		[Token(Token = "0x6006202")]
		[Address(RVA = "0x9B2A04", Offset = "0x9B2A04", VA = "0x9B2A04")]
		public double ParseExpression()
		{
			return default(double);
		}

		[Token(Token = "0x6006203")]
		[Address(RVA = "0x9B2EA0", Offset = "0x9B2EA0", VA = "0x9B2EA0")]
		private void BuildAndCacheExpression()
		{
		}

		[Token(Token = "0x6006204")]
		[Address(RVA = "0x9B3498", Offset = "0x9B3498", VA = "0x9B3498")]
		public MathExpression()
		{
		}
	}
}
