using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Lua_Compiler
{
    public class LuaSerializer
    {
        public static string ToString(IEnumerable<byte> bytecode)
        {
            return bytecode.Aggregate("", (current, v) => current + ("\\" + v));
        }
        
        public byte[] Bytecode;

        public LuaSerializer()
        {
            Bytecode = Array.Empty<byte>();
        }
    }
}