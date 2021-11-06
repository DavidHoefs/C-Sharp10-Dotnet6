
string? info = null;

SayHi(info);

static void SayHi(string message)
{

    // No more if statement!!
    ArgumentNullException.ThrowIfNull(message);

    Console.WriteLine($"Hello {message}");
}