using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JVM.Runner {
    public class OpCode {
        public OpCodeName Name;
        public byte Value;
        public uint OperandSize;
        public int StackChange;

        public uint OpCodeSize => OperandSize + 1;
    }
}
