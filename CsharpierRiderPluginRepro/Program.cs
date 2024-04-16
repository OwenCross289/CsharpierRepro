using CsharpierRiderPluginRepro;

var message = new Message()
{
    Header = "KRISE: Manglende produkt!",
    Body =
        "Jeg gikk gjennom vÃ¥r handleliste og sÃ¥ at vi glemte melk! Ã… nei!!! Vi trenger dette for Ã¥ lage vaffler til fredag, moralen kommer til falle drastisk!"
};

Console.WriteLine(message.Body);
