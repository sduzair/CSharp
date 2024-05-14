internal class Flags
{
    public bool Nsfw { get; set; }
    public bool Religious { get; set; }
    public bool Political { get; set; }
    public bool Racist { get; set; }
    public bool Sexist { get; set; }
    public bool Explicit { get; set; }
    public override string ToString()
    {
        return $"Nsfw: {Nsfw}\nReligious: {Religious}\nPolitical: {Political}\nRacist: {Racist}\nSexist: {Sexist}\nExplicit: {Explicit}";
    }
}