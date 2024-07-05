using PlayGround.Samples;

Console.WriteLine("Welcome");

bool retry = false;
do
{
    Console.WriteLine("************* Game Starts *******************");
    
    var sampleObj = new SampleObject();
    sampleObj.FindFactorial();

    Console.WriteLine("--------------- Game completed -------------------");
    Console.WriteLine(" Press 1 to try again ");
    var  retryInput= int.Parse(Console.ReadLine());
    retry = (retryInput ==1) ? true : false;
} while (retry );


 