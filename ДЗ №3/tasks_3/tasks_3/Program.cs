using System;

Key C = new(Note.C, Octave.second, Accidental.sharp);

Key D = new(Note.B, Octave.first, Accidental.flat);

Console.WriteLine(C.CompareTo(D));

Console.WriteLine(C); // C#

Console.WriteLine(D.Equals(C));

Console.WriteLine(D.GetHashCode());

Console.WriteLine(C.GetHashCode());




