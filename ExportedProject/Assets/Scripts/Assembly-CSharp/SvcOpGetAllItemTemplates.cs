using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000937")]
public class SvcOpGetAllItemTemplates : SvcOpPost
{
	[Token(Token = "0x400320F")]
	private const string SVCOPNAME = "GetAllItemTemplates";

	[Token(Token = "0x4003210")]
	private const string QUERYSTRING_PARAM_TYPE_KEY = "s_type";

	[Token(Token = "0x4003211")]
	private const string QUERYSTRING_PARAM_CLASS_KEY = "s_class";

	[Token(Token = "0x4003212")]
	private const string QUERYSTRING_PARAM_LANGUAGE_KEY = "s_language";

	[Token(Token = "0x17000765")]
	public override string SvcOpCmd
	{
		[Token(Token = "0x6003A77")]
		[Address(RVA = "0xD371B0", Offset = "0xD371B0", VA = "0xD371B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A76")]
	[Address(RVA = "0xD37134", Offset = "0xD37134", VA = "0xD37134")]
	public SvcOpGetAllItemTemplates([Optional] Action<IResponseContext> responseFunction)
	{
	}

	[Token(Token = "0x6003A78")]
	[Address(RVA = "0xD371F4", Offset = "0xD371F4", VA = "0xD371F4")]
	public void Post(string jsonParams, string itemType = "", string itemClass = "", string language = "")
	{
	}
}
