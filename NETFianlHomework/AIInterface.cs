namespace NETFianlHomework
{
    interface AIInterface
    {
        void GetNextStep(out int _x, out int _y);
        void Running(int[,] board, int now);
    }
}
