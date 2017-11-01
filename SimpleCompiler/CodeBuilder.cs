using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompiler
{
    public class CodeBuilder
    {
        public class CodeLine
        {
            public CodeLine(String line, long memoryAddress)
            {
                this.Line = line;
                this.MemoryAddress = memoryAddress;
            }

            public String Line { get; set; }
            public long MemoryAddress { get; set; }

            public override string ToString()
            {
                return this.MemoryAddress + "\t" + this.Line;
            }
        }

        private List<CodeLine> code = new List<CodeLine>();

        private Dictionary<String, List<int>> datos = new Dictionary<string, List<int>>();

        private Dictionary<String, long> posMem = new Dictionary<string, long>();

        private long baseMemory = 1000;
        private long dataMemory = 5000;

        internal void BuildAssignment(string nombreVariable, List<int> c)
        {
            datos.Add(nombreVariable, c);
            posMem.Add(nombreVariable, dataMemory);

            code.Add(new CodeLine("MOV " + (dataMemory++) + ", " + c.Count, baseMemory++));

            foreach (var item in c)
            {
                code.Add(new CodeLine("MOV " + (dataMemory++) + ", " + item, baseMemory++));
            }

            code.Add(new CodeLine("", baseMemory++));

        }
        internal void BuildCreateSet(int desde, int hasta, int salto)
        {
            String nombreVariable = "___AUX";
            posMem.Add(nombreVariable, dataMemory);

            code.Add(new CodeLine("MOV REG1, " + desde, baseMemory++));
            code.Add(new CodeLine("MOV REG2, " + dataMemory++, baseMemory++));
            
            long jumpTo = baseMemory;
            code.Add(new CodeLine("MOV &REG2, REG1", baseMemory++));
            code.Add(new CodeLine("ADD REG1, " + salto, baseMemory++));
            code.Add(new CodeLine("ADD REG2, 1", baseMemory++));
            code.Add(new CodeLine("CMP REG1, " + hasta, baseMemory++));
            code.Add(new CodeLine("JLE " + jumpTo, baseMemory++));

            //VAMOS POR ACA. 25-10-2017

            code.Add(new CodeLine("", baseMemory++));
        }

        internal void PrintCode()
        {
            Console.WriteLine("-----------------------------------------");
            foreach (var item in this.code)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");
        }

        internal void PrintVariables()
        {
            Console.WriteLine("-----------------------------------------");
            foreach (var item in this.posMem.Keys)
            {
                Console.WriteLine(item + " --> " + this.posMem[item]);
            }
            Console.WriteLine("-----------------------------------------");
        }

        
    }
}
