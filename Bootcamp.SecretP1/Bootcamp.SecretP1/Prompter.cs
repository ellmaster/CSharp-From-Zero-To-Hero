using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp.SecretP1
{
    public class Prompter : IEnumerable<string>
    {
        private Dictionary<string, object> questions = new Dictionary<string, object>
        {
            ["What is my first return value?"] = SecretStuff.FirstValue,
            ["What is my second return value?"] = SecretStuff.SecretArray[0],
            ["What is my third return value?"] = SecretStuff.SecretArray[14],
            ["What is my last return value?"] = SecretStuff.SecretArray[29]
        };

        private string lastQuestionAsked;

        public static Prompter Instance { get; } = new Prompter();

        public object DebugValue(string question)
        {
            lastQuestionAsked = question;
            return questions[question];
        }

        public bool IsCorrectAnswer(string answer)
        {
            if (int.TryParse(answer, out int result))
            {
                return questions[lastQuestionAsked].Equals((object)result);
            }

            return questions[lastQuestionAsked].Equals(answer);
        }

        public IEnumerator<string> GetEnumerator() => questions.Keys.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }
}
