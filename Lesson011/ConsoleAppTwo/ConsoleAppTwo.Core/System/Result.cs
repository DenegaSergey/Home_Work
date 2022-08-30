namespace Airport.Core.System
{
    public class Result
    {
        public bool AnswerIsYes { get; private init; }

        public static Result Yes { get; } = new() { AnswerIsYes = true };

        public static Result No()
        {
            var result = new Result { AnswerIsYes = false };
            return result;
        }
    }
}
