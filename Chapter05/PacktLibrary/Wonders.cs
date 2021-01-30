/*
 *   Use the enum values to store combinations of
    discreet options. Derive an enum type from byte if there are up to
    eight options, from short if there are up to 16 options, from int
    if there are up to 32 options, and from long if there are up to 64
    options.
 */

namespace PacktLibrary
{
    [System.Flags]
    public enum Wonders : byte
    {
        None                  = 0b_0000_0000,  // 0
        GreatPyramid          = 0b_0000_0001,  // 1
        HangingGardens        = 0b_0000_0010,  // 2
        StatueOfZeus          = 0b_0000_0100,  // 4
        TempleOfArtemis       = 0b_0000_1000,  // 8
        Mausoleum             = 0b_0001_0000,  // 16
        Colossus              = 0b_0010_0000,  // 32
        LighthouseOfAlexandia = 0b_0100_0000,  // 64
    }
}
