using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BFE")]
	public class SettingsConfiguration
	{
		[Token(Token = "0x4003BF2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string CONFIGURATION_FILE_SETTINGS_NODE;

		[Token(Token = "0x4003BF3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string INITIAL_JSON;

		[Token(Token = "0x6004BEA")]
		[Address(RVA = "0x83DAE0", Offset = "0x83DAE0", VA = "0x83DAE0")]
		public JSONNode ToJSON()
		{
			return null;
		}

		[Token(Token = "0x6004BEB")]
		[Address(RVA = "0x83DB28", Offset = "0x83DB28", VA = "0x83DB28")]
		public void Parse(JSONNode l_configNode)
		{
		}

		[Token(Token = "0x6004BEC")]
		[Address(RVA = "0x83DC08", Offset = "0x83DC08", VA = "0x83DC08")]
		public SettingsConfiguration()
		{
		}
	}
}
