using System;
public struct Key : IComparable<Key>
{
    private Octave Octave { get; }
    private Note Note { get; }
    private Accidental Accidental { get; }

    public Key(Note note, Octave octave, Accidental accidental)
    {
        if ((octave == Octave.sub_contra && note != Note.A && note != Note.B) || (octave == Octave.fifth && note != Note.C))
        {
            this.Octave = Octave.sub_contra; // при вводе невозможной клавиши ей присвоятся эти значения
            this.Note = Note.A;
            this.Accidental = Accidental.none;
        }
        else
        {
            if (note > (Note)6 || octave > (Octave)8 || accidental > (Accidental)2) // при попытке ввода интовых значений (это же enum)
            {
                this.Octave = Octave.sub_contra; // при вводе невозможной клавиши ей присвоятся эти значения
                this.Note = Note.A;
                this.Accidental = Accidental.none;
            }
            else
            {
                this.Octave = octave; // если все ок, то создаем нормальную клавишу
                this.Note = note;
                this.Accidental = accidental;
            }
        }
    }
    
    public double KeyCode() => (int)Note + (int)Octave * 10 + Accidental.ToString() switch // считает "код" клавиши, который помогает ее идентифицировать
        {
            "sharp" => 0.5,
            "flat" => -0.5,
            _ => 0
        };

    public int CompareTo(Key key) => KeyCode().CompareTo(key.KeyCode());

    public override string ToString() => Note + Accidental.ToString() switch
        {
            "sharp" => "#", // значок диез
            "flat"  => "b", // значок бемоль
            _       => ""   // нет знака альтерации
        };

    public override bool Equals(object obj) => obj is Key key && KeyCode() == key.KeyCode();

    public override int GetHashCode() => KeyCode().GetHashCode();
}