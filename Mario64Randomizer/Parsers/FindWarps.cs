using Mario64Randomizer.SM64;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Mario64Randomizer.Parsers
{
    class FindWarpsParser : LevelScript
    {
        class ParseState
        {
            public readonly List<Warp> warps;

            public ParseState()
            {
                warps = new List<Warp>();
            }
        }

        public static List<Warp> FindWarps(ROM rom, int offset)
        {
            ParseState state = new ParseState();
            PerformLevelScriptParse<ParseState>(rom, offset, findWarpsParser, state);
            return state.warps;
        }

        static readonly Parser<ParseState>[] findWarpsParser = new Parser<ParseState>[LevelScript.size];

        static FindWarpsParser()
        {
            Type t = typeof(FindWarpsParser);
            for (int i = 0; i < size; i++)
            {
                findWarpsParser[i] = Common;
                string name = "Cmd" + string.Format("{0:X2}", i);
                MethodInfo info = t.GetMethod(name, BindingFlags.NonPublic | BindingFlags.Static);
                if (info == null)
                    continue;

                if (Delegate.CreateDelegate(typeof(Parser<ParseState>), info) is Parser<ParseState> cmd)
                    findWarpsParser[i] = cmd;
            }
        }

        private static void Common(ROM rom, ParseState state) { }

        // TODO: This is disgusting but I do not know if reflections will work...
        private static void Cmd00(ROM rom, ParseState state) { Cmd00(rom); }
        private static void Cmd06(ROM rom, ParseState state) { Cmd06(rom);}
        private static void Cmd07(ROM rom, ParseState state) { Cmd07(rom); }
        private static void Cmd17(ROM rom, ParseState state) { Cmd17(rom); }

        private static void Cmd26(ROM rom, ParseState state)
        {
            Warp warp = new Warp(rom, rom.offset);
            state.warps.Add(warp);
        }
    }
}
