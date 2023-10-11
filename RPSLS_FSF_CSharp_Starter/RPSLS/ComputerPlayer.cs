using System;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer() : base("Computer")
        {
        }

        public override void ChooseGesture()
        {
            Random random = new Random();
            int index = random.Next(gestures.Count);
            chosenGesture = gestures[index];
        }
    }
}
