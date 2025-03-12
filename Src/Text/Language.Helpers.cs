using System.Text;

namespace oop_adventure
{
    public partial class Language
    {
        private readonly StringBuilder _sb = new StringBuilder(); // creating instance of StringBuilder since it will be referenced a lot

        public virtual string JoinedWordList(string[] words, string conjunction) // creating JoinedWordList and note: [] means list or array
        {
            _sb.Clear(); // clearing it to make sure it is empty 

            for (var i = 0; i < words.Length; i++)
            {
                if (i > 0)
                    _sb.Append(words.Length > 2 ? Comma + Space : Space);

                if (i == words.Length - 1 && words.Length > 1)
                {
                    _sb.Append(conjunction + Space);
                }

                _sb.Append(words[i]);
            }
            return _sb.ToString();
        }
    }
}
