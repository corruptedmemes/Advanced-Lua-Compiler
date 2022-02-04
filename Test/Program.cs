using System.IO;
using Advanced_Lua_Compiler;

namespace Test
{
    internal static class Program
    {
        public static void Main()
        {
            var file = File.ReadAllText("input.lua");

            var compiled = new LuaCompiler();
            
            File.WriteAllText("output.luac", LuaSerializer.ToString(new LuaSerializer().Bytecode));
        }
    }
}