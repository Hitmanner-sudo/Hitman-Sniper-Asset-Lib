using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B87")]
	public class TemplateData : BaseShopData
	{
		[Token(Token = "0x2000B88")]
		public delegate void TemplateDataHandler(TemplateData segment);

		[Token(Token = "0x2000B89")]
		public delegate void TemplateDataListHandler(List<TemplateData> list);

		[Token(Token = "0x2000B8A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x598230", Offset = "0x598230")]
		private sealed class _003C_003Ec__DisplayClass33_0
		{
			[Token(Token = "0x4003A7A")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGetAllItemTemplatesRaw svcOpC;

			[Token(Token = "0x6004974")]
			[Address(RVA = "0xA55700", Offset = "0xA55700", VA = "0xA55700")]
			public _003C_003Ec__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6004975")]
			[Address(RVA = "0xA55708", Offset = "0xA55708", VA = "0xA55708")]
			internal void _003CGetTemplateList_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B8B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x598240", Offset = "0x598240")]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			[Token(Token = "0x4003A7B")]
			[FieldOffset(Offset = "0x10")]
			public TemplateData _003C_003E4__this;

			[Token(Token = "0x4003A7C")]
			[FieldOffset(Offset = "0x18")]
			public SvcOpCreateItemTemplate svcOpC;

			[Token(Token = "0x6004976")]
			[Address(RVA = "0xA55D54", Offset = "0xA55D54", VA = "0xA55D54")]
			public _003C_003Ec__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6004977")]
			[Address(RVA = "0xA55D5C", Offset = "0xA55D5C", VA = "0xA55D5C")]
			internal void _003CCreate_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x598250", Offset = "0x598250")]
		private sealed class _003C_003Ec__DisplayClass35_0
		{
			[Token(Token = "0x4003A7D")]
			[FieldOffset(Offset = "0x10")]
			public TemplateData _003C_003E4__this;

			[Token(Token = "0x4003A7E")]
			[FieldOffset(Offset = "0x18")]
			public SvcOpUpdateItemTemplate svcOpC;

			[Token(Token = "0x6004978")]
			[Address(RVA = "0xA55EE4", Offset = "0xA55EE4", VA = "0xA55EE4")]
			public _003C_003Ec__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6004979")]
			[Address(RVA = "0xA55EEC", Offset = "0xA55EEC", VA = "0xA55EEC")]
			internal void _003CUpdate_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x2000B8D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x598260", Offset = "0x598260")]
		private sealed class _003C_003Ec__DisplayClass36_0
		{
			[Token(Token = "0x4003A7F")]
			[FieldOffset(Offset = "0x10")]
			public TemplateData _003C_003E4__this;

			[Token(Token = "0x4003A80")]
			[FieldOffset(Offset = "0x18")]
			public SvcIOpDeleteItemTemplate svcOpC;

			[Token(Token = "0x600497A")]
			[Address(RVA = "0xA56070", Offset = "0xA56070", VA = "0xA56070")]
			public _003C_003Ec__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600497B")]
			[Address(RVA = "0xA56078", Offset = "0xA56078", VA = "0xA56078")]
			internal void _003CDelete_003Eb__0(IResponseContext response)
			{
			}
		}

		[Token(Token = "0x4003A73")]
		[FieldOffset(Offset = "0x60")]
		public string ItemType;

		[Token(Token = "0x4003A74")]
		[FieldOffset(Offset = "0x68")]
		public string ItemClass;

		[Token(Token = "0x4003A75")]
		[FieldOffset(Offset = "0x70")]
		public bool IsConsumable;

		[Token(Token = "0x4003A76")]
		[FieldOffset(Offset = "0x71")]
		public bool Premium;

		[Token(Token = "0x4003A77")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<LanguageCode, LocalizationEntry> LocaInfos;

		[Token(Token = "0x4003A78")]
		[FieldOffset(Offset = "0x80")]
		public string BundleURL;

		[Token(Token = "0x4003A79")]
		[FieldOffset(Offset = "0x88")]
		public string Sku;

		[Token(Token = "0x17000935")]
		public override string ObjectName
		{
			[Token(Token = "0x600495F")]
			[Address(RVA = "0xB5A114", Offset = "0xB5A114", VA = "0xB5A114", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000936")]
		public override bool HasSetMandatoryValues
		{
			[Token(Token = "0x6004961")]
			[Address(RVA = "0xB5A378", Offset = "0xB5A378", VA = "0xB5A378", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1400010F")]
		public event TemplateDataHandler OnCreate
		{
			[Token(Token = "0x6004953")]
			[Address(RVA = "0xB597D8", Offset = "0xB597D8", VA = "0xB597D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627658", Offset = "0x627658")]
			add
			{
			}
			[Token(Token = "0x6004954")]
			[Address(RVA = "0xB59878", Offset = "0xB59878", VA = "0xB59878")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627668", Offset = "0x627668")]
			remove
			{
			}
		}

		[Token(Token = "0x14000110")]
		public event TemplateDataHandler OnUpdate
		{
			[Token(Token = "0x6004955")]
			[Address(RVA = "0xB59918", Offset = "0xB59918", VA = "0xB59918")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627678", Offset = "0x627678")]
			add
			{
			}
			[Token(Token = "0x6004956")]
			[Address(RVA = "0xB599B8", Offset = "0xB599B8", VA = "0xB599B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627688", Offset = "0x627688")]
			remove
			{
			}
		}

		[Token(Token = "0x14000111")]
		public event TemplateDataHandler OnDelete
		{
			[Token(Token = "0x6004957")]
			[Address(RVA = "0xB59A58", Offset = "0xB59A58", VA = "0xB59A58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627698", Offset = "0x627698")]
			add
			{
			}
			[Token(Token = "0x6004958")]
			[Address(RVA = "0xB59AF8", Offset = "0xB59AF8", VA = "0xB59AF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276A8", Offset = "0x6276A8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000112")]
		public event TemplateDataHandler OnError
		{
			[Token(Token = "0x6004959")]
			[Address(RVA = "0xB59B98", Offset = "0xB59B98", VA = "0xB59B98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276B8", Offset = "0x6276B8")]
			add
			{
			}
			[Token(Token = "0x600495A")]
			[Address(RVA = "0xB59C38", Offset = "0xB59C38", VA = "0xB59C38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276C8", Offset = "0x6276C8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000113")]
		public static event TemplateDataListHandler OnGetTemplateList
		{
			[Token(Token = "0x600495B")]
			[Address(RVA = "0xB59CD8", Offset = "0xB59CD8", VA = "0xB59CD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276D8", Offset = "0x6276D8")]
			add
			{
			}
			[Token(Token = "0x600495C")]
			[Address(RVA = "0xB59D94", Offset = "0xB59D94", VA = "0xB59D94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276E8", Offset = "0x6276E8")]
			remove
			{
			}
		}

		[Token(Token = "0x600495D")]
		[Address(RVA = "0xB59E50", Offset = "0xB59E50", VA = "0xB59E50")]
		public TemplateData()
		{
		}

		[Token(Token = "0x600495E")]
		[Address(RVA = "0xB59E58", Offset = "0xB59E58", VA = "0xB59E58")]
		public TemplateData(TemplateData obj)
		{
		}

		[Token(Token = "0x6004960")]
		[Address(RVA = "0xB5A158", Offset = "0xB5A158", VA = "0xB5A158", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004962")]
		[Address(RVA = "0xB5A57C", Offset = "0xB5A57C", VA = "0xB5A57C", Slot = "11")]
		internal override void FromJSON(JSONNode node)
		{
		}

		[Token(Token = "0x6004963")]
		[Address(RVA = "0xB5AA0C", Offset = "0xB5AA0C", VA = "0xB5AA0C", Slot = "10")]
		internal override string ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6004964")]
		[Address(RVA = "0xB5AF94", Offset = "0xB5AF94", VA = "0xB5AF94")]
		public static void GetTemplateList()
		{
		}

		[Token(Token = "0x6004965")]
		[Address(RVA = "0xB5B340", Offset = "0xB5B340", VA = "0xB5B340", Slot = "12")]
		public override bool Create()
		{
			return default(bool);
		}

		[Token(Token = "0x6004966")]
		[Address(RVA = "0xB5B49C", Offset = "0xB5B49C", VA = "0xB5B49C", Slot = "13")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6004967")]
		[Address(RVA = "0xB5B5DC", Offset = "0xB5B5DC", VA = "0xB5B5DC", Slot = "14")]
		public override bool Delete()
		{
			return default(bool);
		}

		[Token(Token = "0x6004968")]
		[Address(RVA = "0xB5B70C", Offset = "0xB5B70C", VA = "0xB5B70C")]
		private void TriggerEvent(TemplateDataHandler handler)
		{
		}

		[Token(Token = "0x6004969")]
		[Address(RVA = "0xB5B728", Offset = "0xB5B728", VA = "0xB5B728")]
		[DebuggerHidden]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6276F8", Offset = "0x6276F8")]
		private bool _003C_003En__0()
		{
			return default(bool);
		}

		[Token(Token = "0x600496A")]
		[Address(RVA = "0xB5B730", Offset = "0xB5B730", VA = "0xB5B730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627730", Offset = "0x627730")]
		[DebuggerHidden]
		private bool _003C_003En__1()
		{
			return default(bool);
		}

		[Token(Token = "0x600496B")]
		[Address(RVA = "0xB5B738", Offset = "0xB5B738", VA = "0xB5B738")]
		[DebuggerHidden]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x627768", Offset = "0x627768")]
		private bool _003C_003En__2()
		{
			return default(bool);
		}
	}
}
