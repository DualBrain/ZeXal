﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeXal.CPUCore.Opcodes
{
    //SCF
    //Description:
    //Set carry flag
    //
    //Flags affected:
    //Z - Not affected.
    //N - Reset.
    //H - Reset.
    //C - Set.

    //0x37
    class SCF : Opcode
    {
        public override int Execute(CPU cpu)
        {
            cpu.regs.SetFlag(Flags.C);
            cpu.regs.ClearFlag(Flags.N);
            cpu.regs.ClearFlag(Flags.H);
            cpu.regs.IncreasePC(1);
            return 4;
        }

        public override string GetOpcodeData(IMemoryMapper memorymap, ushort address, out byte n_bytes)
        {
            n_bytes = 1;
            return "scf";
        }
    }
    
}
