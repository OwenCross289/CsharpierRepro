using CsharpierRiderPluginRepro;

var message = new Message()
{
    Header = "KRISE: Manglende produkt!",
    Body = "Jeg gikk gjennom vår handleliste og så at vi glemte melk! Å nei!!! Vi trenger dette for å lage vaffler til fredag, moralen kommer til falle drastisk!"
};


Console.WriteLine(message.Body);
