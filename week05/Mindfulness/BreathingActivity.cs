public class BreathingActivity : Activity
{
    public BreathingActivity() : base("breathing", "This activity will help you relax by walking your mind through breathing in and out slowly. \nClear your mind and focus on your breathing.")
    {
    }

    // Method to run the Breathing Activity
    public override void Run()
    {
        base.Run();
        DisplayStringMessage();

        // Message that repeats during the period of time the user choosed
        int interval = _duration / 2;
        for (int i = 0; i < interval; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(3);
            Console.Write("Breathe out... ");
            ShowCountdown(3);
            Console.WriteLine();
        }

        // Calling the function that finish the activity and show the menu to the user again
        DisplayEndingMessage();
    }
}
