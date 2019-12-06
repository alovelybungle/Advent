using System;
using System.Collections.Generic;
using System.Text;

namespace Advent
{
    public class Computer
    {
        // :(
        public object MagicSmoke { get; set; } = null;

        
        public int[] RunIntCodeProgram(int[] input)
        {
            void ProcessLine(Span<int> line)
            {
                var opCode = line[0];

                if(opCode == 99)
                {
                    return;
                }

                if(line.Length != 4)
                {
                    return;
                }

                var left = line[1];
                var right = line[2];
                var target = line[3];

                switch (opCode)
                {
                    case 1:
                        input[target] = input[left] + input[right];
                        return;
                    case 2:
                        input[target] = input[left] * input[right];
                        return;
                    case 99:
                        return;
                    default:
                        throw new InvalidOperationException($"Invalid OpCode: { opCode }");
                }
            }

            if (input == null || input.Length == 0)
            {
                throw new ArgumentException(nameof(input));
            }

            var i = 0;
            var span = new Span<int>(input);

            while (i < span.Length)
            {
                var length = Math.Min(4, span.Length - i);

                ProcessLine(span.Slice(i, length));

                i += 4;
            }

            return input;
        }
    }
}
